namespace PkmnCalcWinFormsUI
{
    partial class PokemonTypeCalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PokemonTypeCalculatorForm));
            this.primaryTypeLabel = new System.Windows.Forms.Label();
            this.secondaryTypeLabel = new System.Windows.Forms.Label();
            this.defendingPokemonTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.secondaryTypeComboBox = new System.Windows.Forms.ComboBox();
            this.primaryTypeComboBox = new System.Windows.Forms.ComboBox();
            this.showDamageTakenButton = new System.Windows.Forms.Button();
            this.pkmnTypeObjectListView = new BrightIdeasSoftware.ObjectListView();
            this.typeColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.dmgMultiplierColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.defendingPokemonTypeGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pkmnTypeObjectListView)).BeginInit();
            this.SuspendLayout();
            // 
            // primaryTypeLabel
            // 
            this.primaryTypeLabel.AutoSize = true;
            this.primaryTypeLabel.ForeColor = System.Drawing.Color.White;
            this.primaryTypeLabel.Location = new System.Drawing.Point(41, 25);
            this.primaryTypeLabel.Name = "primaryTypeLabel";
            this.primaryTypeLabel.Size = new System.Drawing.Size(101, 21);
            this.primaryTypeLabel.TabIndex = 0;
            this.primaryTypeLabel.Text = "Primary Type";
            // 
            // secondaryTypeLabel
            // 
            this.secondaryTypeLabel.AutoSize = true;
            this.secondaryTypeLabel.Location = new System.Drawing.Point(248, 25);
            this.secondaryTypeLabel.Name = "secondaryTypeLabel";
            this.secondaryTypeLabel.Size = new System.Drawing.Size(119, 21);
            this.secondaryTypeLabel.TabIndex = 1;
            this.secondaryTypeLabel.Text = "Secondary Type";
            // 
            // defendingPokemonTypeGroupBox
            // 
            this.defendingPokemonTypeGroupBox.Controls.Add(this.secondaryTypeComboBox);
            this.defendingPokemonTypeGroupBox.Controls.Add(this.primaryTypeComboBox);
            this.defendingPokemonTypeGroupBox.Controls.Add(this.primaryTypeLabel);
            this.defendingPokemonTypeGroupBox.Controls.Add(this.secondaryTypeLabel);
            this.defendingPokemonTypeGroupBox.ForeColor = System.Drawing.Color.White;
            this.defendingPokemonTypeGroupBox.Location = new System.Drawing.Point(12, 12);
            this.defendingPokemonTypeGroupBox.Name = "defendingPokemonTypeGroupBox";
            this.defendingPokemonTypeGroupBox.Size = new System.Drawing.Size(410, 108);
            this.defendingPokemonTypeGroupBox.TabIndex = 2;
            this.defendingPokemonTypeGroupBox.TabStop = false;
            this.defendingPokemonTypeGroupBox.Text = "Defending Pokemon Types";
            // 
            // secondaryTypeComboBox
            // 
            this.secondaryTypeComboBox.BackColor = System.Drawing.Color.Black;
            this.secondaryTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.secondaryTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.secondaryTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.secondaryTypeComboBox.ForeColor = System.Drawing.Color.White;
            this.secondaryTypeComboBox.FormattingEnabled = true;
            this.secondaryTypeComboBox.Location = new System.Drawing.Point(246, 50);
            this.secondaryTypeComboBox.Name = "secondaryTypeComboBox";
            this.secondaryTypeComboBox.Size = new System.Drawing.Size(121, 30);
            this.secondaryTypeComboBox.TabIndex = 3;
            this.secondaryTypeComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.secondaryTypeComboBox_DrawItem);
            this.secondaryTypeComboBox.DropDownClosed += new System.EventHandler(this.secondaryTypeComboBox_DropDownClosed);
            // 
            // primaryTypeComboBox
            // 
            this.primaryTypeComboBox.BackColor = System.Drawing.Color.Black;
            this.primaryTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.primaryTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.primaryTypeComboBox.ForeColor = System.Drawing.Color.White;
            this.primaryTypeComboBox.FormattingEnabled = true;
            this.primaryTypeComboBox.Location = new System.Drawing.Point(31, 50);
            this.primaryTypeComboBox.Name = "primaryTypeComboBox";
            this.primaryTypeComboBox.Size = new System.Drawing.Size(121, 30);
            this.primaryTypeComboBox.TabIndex = 2;
            this.primaryTypeComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.primaryTypeComboBox_DrawItem);
            this.primaryTypeComboBox.DropDownClosed += new System.EventHandler(this.primaryTypeComboBox_DropDownClosed);
            // 
            // showDamageTakenButton
            // 
            this.showDamageTakenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.showDamageTakenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showDamageTakenButton.ForeColor = System.Drawing.Color.White;
            this.showDamageTakenButton.Location = new System.Drawing.Point(12, 127);
            this.showDamageTakenButton.Name = "showDamageTakenButton";
            this.showDamageTakenButton.Size = new System.Drawing.Size(410, 32);
            this.showDamageTakenButton.TabIndex = 4;
            this.showDamageTakenButton.Text = "Show damage taken";
            this.showDamageTakenButton.UseVisualStyleBackColor = false;
            this.showDamageTakenButton.Click += new System.EventHandler(this.showDamageTakenButton_Click);
            // 
            // pkmnTypeObjectListView
            // 
            this.pkmnTypeObjectListView.AllColumns.Add(this.typeColumn);
            this.pkmnTypeObjectListView.AllColumns.Add(this.dmgMultiplierColumn);
            this.pkmnTypeObjectListView.CellEditUseWholeCell = false;
            this.pkmnTypeObjectListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.typeColumn,
            this.dmgMultiplierColumn});
            this.pkmnTypeObjectListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.pkmnTypeObjectListView.HideSelection = false;
            this.pkmnTypeObjectListView.Location = new System.Drawing.Point(12, 166);
            this.pkmnTypeObjectListView.Name = "pkmnTypeObjectListView";
            this.pkmnTypeObjectListView.Scrollable = false;
            this.pkmnTypeObjectListView.SelectColumnsOnRightClick = false;
            this.pkmnTypeObjectListView.SelectColumnsOnRightClickBehaviour = BrightIdeasSoftware.ObjectListView.ColumnSelectBehaviour.None;
            this.pkmnTypeObjectListView.ShowGroups = false;
            this.pkmnTypeObjectListView.Size = new System.Drawing.Size(410, 483);
            this.pkmnTypeObjectListView.TabIndex = 5;
            this.pkmnTypeObjectListView.UseCompatibleStateImageBehavior = false;
            this.pkmnTypeObjectListView.View = System.Windows.Forms.View.Details;
            this.pkmnTypeObjectListView.Visible = false;
            this.pkmnTypeObjectListView.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.pkmnTypeObjectListView_FormatRow);
            // 
            // typeColumn
            // 
            this.typeColumn.AspectName = "TypeName";
            this.typeColumn.FillsFreeSpace = true;
            this.typeColumn.IsEditable = false;
            this.typeColumn.Text = "Type";
            this.typeColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dmgMultiplierColumn
            // 
            this.dmgMultiplierColumn.AspectName = "DmgMultiplier";
            this.dmgMultiplierColumn.AspectToStringFormat = "{0}x";
            this.dmgMultiplierColumn.FillsFreeSpace = true;
            this.dmgMultiplierColumn.IsEditable = false;
            this.dmgMultiplierColumn.Text = "Damage Multiplier";
            this.dmgMultiplierColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PokemonTypeCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(434, 661);
            this.Controls.Add(this.pkmnTypeObjectListView);
            this.Controls.Add(this.showDamageTakenButton);
            this.Controls.Add(this.defendingPokemonTypeGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(450, 700);
            this.MinimumSize = new System.Drawing.Size(450, 700);
            this.Name = "PokemonTypeCalculatorForm";
            this.Text = "Pokemon Type Calculator - WinForms";
            this.defendingPokemonTypeGroupBox.ResumeLayout(false);
            this.defendingPokemonTypeGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pkmnTypeObjectListView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label primaryTypeLabel;
        private System.Windows.Forms.Label secondaryTypeLabel;
        private System.Windows.Forms.GroupBox defendingPokemonTypeGroupBox;
        private System.Windows.Forms.ComboBox secondaryTypeComboBox;
        private System.Windows.Forms.ComboBox primaryTypeComboBox;
        private System.Windows.Forms.Button showDamageTakenButton;
        private BrightIdeasSoftware.ObjectListView pkmnTypeObjectListView;
        private BrightIdeasSoftware.OLVColumn typeColumn;
        private BrightIdeasSoftware.OLVColumn dmgMultiplierColumn;
    }
}