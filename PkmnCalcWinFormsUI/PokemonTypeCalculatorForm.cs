using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PokemonTypeLibrary.Models;

namespace PkmnCalcWinFormsUI
{
    public partial class PokemonTypeCalculatorForm : Form
    {
        // collections used by pokemon defending type comboboxes
        private ObservableCollection<IPkmnType> PrimaryPkmnTypeList { get; set; } = PkmnTypeFactory.GeneratePkmnTypeList();
        private ObservableCollection<IPkmnType> SecondaryPkmnTypeList { get; set; } = PkmnTypeFactory.GeneratePkmnTypeList();

        // collection used by objectlistview
        private ObservableCollection<IPkmnType> PkmnTypeList { get; set; } = PkmnTypeFactory.GeneratePkmnTypeList();

        // properties used for storing the deleted PkmnType from comboboxes
        public IPkmnType DeletedTypeFromPrimaryCombobox { get; set; }
        public IPkmnType DeletedTypeFromSecondaryCombobox { get; set; }

        // properties used for storing indices of PkmnType deleted from the comboboxes
        public int IndexOfDeletedPrimaryType { get; set; }
        public int IndexOfDeletedSecondaryType { get; set; }

        // form constructor
        public PokemonTypeCalculatorForm()
        {
            InitializeComponent();

            // add empty pkmn types to the comboboxes
            PrimaryPkmnTypeList.Insert(0, PkmnTypeFactory.CreateEmptyPkmnType());
            SecondaryPkmnTypeList.Insert(0, PkmnTypeFactory.CreateEmptyPkmnType());

            // set the collection properties as datasources for the comboboxes
            primaryTypeComboBox.DataSource = PrimaryPkmnTypeList;
            secondaryTypeComboBox.DataSource = SecondaryPkmnTypeList;

            // set the name of the pokemon type as a displayed value for comboboxes
            primaryTypeComboBox.DisplayMember = "TypeName";
            secondaryTypeComboBox.DisplayMember = "TypeName";

            // set the collection for list view
            pkmnTypeObjectListView.SetObjects(PkmnTypeList);

            // set focus on damage taken button
            showDamageTakenButton.Select();
        }

        // show damage taken button click event handler
        private void showDamageTakenButton_Click(object sender, EventArgs e)
        {
            // check if both comboboxes select the (none) type
            if (primaryTypeComboBox.SelectedItem is EmptyPkmnType && secondaryTypeComboBox.SelectedItem is EmptyPkmnType)
            {
                // hide objectlistview that displays dmg multipliers
                pkmnTypeObjectListView.Visible = false;
                return;
            }

            // calculate damage multiplier for each pkmn type in the list
            foreach (var pkmnType in PkmnTypeList)
            {
                pkmnType.DmgMultiplier = pkmnType.CalculateDmgMultiplier((IPkmnType)primaryTypeComboBox.SelectedItem, (IPkmnType)secondaryTypeComboBox.SelectedItem);
            }

            // refresh objectlistview containing pkmn types and dmg multipliers
            pkmnTypeObjectListView.RefreshObjects(PkmnTypeList);

            // sort by damage multiplier from highest to lowest
            pkmnTypeObjectListView.Sort(dmgMultiplierColumn, SortOrder.Descending);

            // show objectlistview
            pkmnTypeObjectListView.Visible = true;
        }

        // listview row draw event handler sets background color corresponding to pkmn type
        private void pkmnTypeObjectListView_FormatRow(object sender, BrightIdeasSoftware.FormatRowEventArgs e)
        {
            IPkmnType pkmnTypeModel = (IPkmnType)e.Model;
            ColorConverter cc = new ColorConverter();
            e.Item.BackColor =  (Color)cc.ConvertFromString(pkmnTypeModel.TypeColor);
        }

        // event handler that sets the color of primary type comboboxes font color and highlight color
        private void primaryTypeComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Draw the background 
            e.DrawBackground();
            
            // Get the item current item   
            IPkmnType item = (IPkmnType)(((ComboBox)sender).Items[e.Index]);

            ColorConverter cc = new ColorConverter();

            // Determine the forecolor based on whether or not the item is selected    
            using (SolidBrush highlightBrush = new SolidBrush(Color.FromArgb(28, 28, 28)))
            {
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    e.Graphics.FillRectangle(highlightBrush, e.Bounds);
                } 
            }

            // Draw the text    
            using (SolidBrush brush = new SolidBrush((Color)cc.ConvertFromString(item.TypeColor)))
            {
                e.Graphics.DrawString(item.TypeName, ((Control)sender).Font, brush, e.Bounds.X, e.Bounds.Y);
            }

            e.DrawFocusRectangle();
        }

        // event handler that sets the color of secondary type comboboxes font color and highlight color
        private void secondaryTypeComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Draw the background 
            e.DrawBackground();

            // Get the item text    
            IPkmnType item = (IPkmnType)(((ComboBox)sender).Items[e.Index]);

            ColorConverter cc = new ColorConverter();

            using (SolidBrush highlightBrush = new SolidBrush(Color.FromArgb(28, 28, 28)))
            {
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    e.Graphics.FillRectangle(highlightBrush, e.Bounds);
                }
            }

            // Determine the forecolor based on whether or not the item is selected    
            using (SolidBrush brush = new SolidBrush((Color)cc.ConvertFromString(item.TypeColor)))
            {
                // Draw the text    
                e.Graphics.DrawString(item.TypeName, ((Control)sender).Font, brush, e.Bounds.X, e.Bounds.Y);
            }
            e.DrawFocusRectangle();
        }

        // event handler for primary type combobox DropDownClosed event
        private void primaryTypeComboBox_DropDownClosed(object sender, EventArgs e)
        {
            // if the type was deleted from secondary type combobox insert it back and reset variable
            if (DeletedTypeFromSecondaryCombobox != null)
            {
                SecondaryPkmnTypeList.Insert(IndexOfDeletedSecondaryType, DeletedTypeFromSecondaryCombobox);
                DeletedTypeFromSecondaryCombobox = null;
            }
            
            // helper variable
            var selectedPrimaryType = primaryTypeComboBox.SelectedItem as IPkmnType;

            // if selected primarytype is not "(none)" delete it from secondarytype list and save to "Deleted" properties
            if (!(selectedPrimaryType is EmptyPkmnType))
            {
                DeletedTypeFromSecondaryCombobox = SecondaryPkmnTypeList.Where(i => i.TypeName == selectedPrimaryType.TypeName).FirstOrDefault();
                IndexOfDeletedSecondaryType = SecondaryPkmnTypeList.IndexOf(DeletedTypeFromSecondaryCombobox);
                SecondaryPkmnTypeList.Remove(SecondaryPkmnTypeList.Where(i => i.TypeName == selectedPrimaryType.TypeName).FirstOrDefault());
            }
            
            // refresh secondarytype combobox
            secondaryTypeComboBox.DataSource = null;
            secondaryTypeComboBox.DataSource = SecondaryPkmnTypeList;

            // if something was selected in secondary combobox select it again after combobox refreshed and possibly changed index
            if (DeletedTypeFromPrimaryCombobox != null)
            {
                secondaryTypeComboBox.SelectedIndex = SecondaryPkmnTypeList.
                    IndexOf(SecondaryPkmnTypeList.
                    Where(i => i.TypeName == DeletedTypeFromPrimaryCombobox.TypeName).FirstOrDefault());
            }
        }

        // event handler for secondary type combobox DropDownClosed event
        private void secondaryTypeComboBox_DropDownClosed(object sender, EventArgs e)
        {
            // if the type was deleted from primary type combobox insert it back and reset variable
            if (DeletedTypeFromPrimaryCombobox != null)
            {
                PrimaryPkmnTypeList.Insert(IndexOfDeletedPrimaryType, DeletedTypeFromPrimaryCombobox);
                DeletedTypeFromPrimaryCombobox = null;
            }

            // helper variable
            var selectedSecondaryType = secondaryTypeComboBox.SelectedItem as IPkmnType;

            // if selected secondarytype is not "(none)" delete it from primarytype list and save to "Deleted" properties
            if (!(selectedSecondaryType is EmptyPkmnType))
            {
                DeletedTypeFromPrimaryCombobox = PrimaryPkmnTypeList.Where(i => i.TypeName == selectedSecondaryType.TypeName).FirstOrDefault();
                IndexOfDeletedPrimaryType = PrimaryPkmnTypeList.IndexOf(DeletedTypeFromPrimaryCombobox);
                PrimaryPkmnTypeList.Remove(PrimaryPkmnTypeList.Where(i => i.TypeName == selectedSecondaryType.TypeName).FirstOrDefault());
            }
            
            // refresh primarytype combobox
            primaryTypeComboBox.DataSource = null;
            primaryTypeComboBox.DataSource = PrimaryPkmnTypeList;

            // if something was selected in primary combobox select it again after combobox refreshed and possibly changed index
            if (DeletedTypeFromSecondaryCombobox != null)
            {
                primaryTypeComboBox.SelectedIndex = PrimaryPkmnTypeList.
                    IndexOf(PrimaryPkmnTypeList.
                    Where(i => i.TypeName == DeletedTypeFromSecondaryCombobox.TypeName).FirstOrDefault()); 
            }
        }
    }
}
