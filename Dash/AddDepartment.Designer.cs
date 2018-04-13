namespace Dash
{
    partial class AddDepartment
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
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.btnAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtDepartmentAddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtDepartmentName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.DodgerBlue;
            this.bunifuCards1.Controls.Add(this.btnAdd);
            this.bunifuCards1.Controls.Add(this.btnCancel);
            this.bunifuCards1.Controls.Add(this.txtDepartmentAddress);
            this.bunifuCards1.Controls.Add(this.txtDepartmentName);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(284, 261);
            this.bunifuCards1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Activecolor = System.Drawing.Color.SteelBlue;
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.BorderRadius = 0;
            this.btnAdd.ButtonText = "Add";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdd.Iconimage = null;
            this.btnAdd.Iconimage_right = null;
            this.btnAdd.Iconimage_right_Selected = null;
            this.btnAdd.Iconimage_Selected = null;
            this.btnAdd.IconMarginLeft = 0;
            this.btnAdd.IconMarginRight = 0;
            this.btnAdd.IconRightVisible = true;
            this.btnAdd.IconRightZoom = 0D;
            this.btnAdd.IconVisible = true;
            this.btnAdd.IconZoom = 90D;
            this.btnAdd.IsTab = false;
            this.btnAdd.Location = new System.Drawing.Point(160, 214);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.OnHovercolor = System.Drawing.Color.SteelBlue;
            this.btnAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdd.selected = false;
            this.btnAdd.Size = new System.Drawing.Size(112, 35);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Textcolor = System.Drawing.Color.White;
            this.btnAdd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Activecolor = System.Drawing.Color.Gray;
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.BorderRadius = 0;
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancel.Iconimage = null;
            this.btnCancel.Iconimage_right = null;
            this.btnCancel.Iconimage_right_Selected = null;
            this.btnCancel.Iconimage_Selected = null;
            this.btnCancel.IconMarginLeft = 0;
            this.btnCancel.IconMarginRight = 0;
            this.btnCancel.IconRightVisible = true;
            this.btnCancel.IconRightZoom = 0D;
            this.btnCancel.IconVisible = true;
            this.btnCancel.IconZoom = 90D;
            this.btnCancel.IsTab = false;
            this.btnCancel.Location = new System.Drawing.Point(13, 214);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.Gray;
            this.btnCancel.OnHovercolor = System.Drawing.Color.LightSlateGray;
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancel.selected = false;
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Textcolor = System.Drawing.Color.White;
            this.btnCancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtDepartmentAddress
            // 
            this.txtDepartmentAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDepartmentAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDepartmentAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDepartmentAddress.HintForeColor = System.Drawing.Color.Empty;
            this.txtDepartmentAddress.HintText = "";
            this.txtDepartmentAddress.isPassword = false;
            this.txtDepartmentAddress.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txtDepartmentAddress.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDepartmentAddress.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txtDepartmentAddress.LineThickness = 3;
            this.txtDepartmentAddress.Location = new System.Drawing.Point(13, 134);
            this.txtDepartmentAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtDepartmentAddress.Name = "txtDepartmentAddress";
            this.txtDepartmentAddress.Size = new System.Drawing.Size(258, 33);
            this.txtDepartmentAddress.TabIndex = 3;
            this.txtDepartmentAddress.Text = "Department Address";
            this.txtDepartmentAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDepartmentAddress.Enter += new System.EventHandler(this.txtDepartmentAddress_Enter);
            this.txtDepartmentAddress.Leave += new System.EventHandler(this.txtDepartmentAddress_Leave);
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDepartmentName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDepartmentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDepartmentName.HintForeColor = System.Drawing.Color.Empty;
            this.txtDepartmentName.HintText = "";
            this.txtDepartmentName.isPassword = false;
            this.txtDepartmentName.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txtDepartmentName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtDepartmentName.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.txtDepartmentName.LineThickness = 3;
            this.txtDepartmentName.Location = new System.Drawing.Point(13, 79);
            this.txtDepartmentName.Margin = new System.Windows.Forms.Padding(4);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(258, 33);
            this.txtDepartmentName.TabIndex = 2;
            this.txtDepartmentName.Text = "Department Name";
            this.txtDepartmentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDepartmentName.Enter += new System.EventHandler(this.txtDepartmentName_Enter);
            this.txtDepartmentName.Leave += new System.EventHandler(this.txtDepartmentName_Leave);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(3, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(169, 30);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Add Department";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuCards1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // AddDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddDepartment";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDepartment";
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdd;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDepartmentAddress;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDepartmentName;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}