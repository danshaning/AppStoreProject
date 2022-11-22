namespace Eurotoy_HW4_ShaningA
{
    partial class Form1
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
            this.Toylst = new System.Windows.Forms.ListBox();
            this.MyCart = new System.Windows.Forms.ListBox();
            this.ItemsDetails = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnAddtoCart = new System.Windows.Forms.Button();
            this.picToy = new System.Windows.Forms.PictureBox();
            this.lblToyName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.ItemsDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picToy)).BeginInit();
            this.SuspendLayout();
            // 
            // Toylst
            // 
            this.Toylst.FormattingEnabled = true;
            this.Toylst.ItemHeight = 16;
            this.Toylst.Location = new System.Drawing.Point(12, 26);
            this.Toylst.Name = "Toylst";
            this.Toylst.Size = new System.Drawing.Size(330, 212);
            this.Toylst.TabIndex = 0;
            this.Toylst.SelectedIndexChanged += new System.EventHandler(this.Toylst_SelectedIndexChanged);
            // 
            // MyCart
            // 
            this.MyCart.FormattingEnabled = true;
            this.MyCart.ItemHeight = 16;
            this.MyCart.Location = new System.Drawing.Point(470, 26);
            this.MyCart.Name = "MyCart";
            this.MyCart.Size = new System.Drawing.Size(335, 212);
            this.MyCart.TabIndex = 1;
            this.MyCart.SelectedIndexChanged += new System.EventHandler(this.MyCart_SelectedIndexChanged);
            // 
            // ItemsDetails
            // 
            this.ItemsDetails.Controls.Add(this.lblPrice);
            this.ItemsDetails.Controls.Add(this.lblToyName);
            this.ItemsDetails.Controls.Add(this.picToy);
            this.ItemsDetails.Location = new System.Drawing.Point(21, 304);
            this.ItemsDetails.Name = "ItemsDetails";
            this.ItemsDetails.Size = new System.Drawing.Size(433, 199);
            this.ItemsDetails.TabIndex = 2;
            this.ItemsDetails.TabStop = false;
            this.ItemsDetails.Text = "Items Details";
            this.ItemsDetails.Enter += new System.EventHandler(this.ItemsDetails_Enter);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Tomato;
            this.btnExit.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(666, 408);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 77);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCheckout.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Location = new System.Drawing.Point(566, 323);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(204, 79);
            this.btnCheckout.TabIndex = 4;
            this.btnCheckout.Text = "CHECKOUT >>";
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // btnAddtoCart
            // 
            this.btnAddtoCart.BackColor = System.Drawing.Color.PeachPuff;
            this.btnAddtoCart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddtoCart.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddtoCart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddtoCart.Location = new System.Drawing.Point(348, 121);
            this.btnAddtoCart.Name = "btnAddtoCart";
            this.btnAddtoCart.Size = new System.Drawing.Size(116, 74);
            this.btnAddtoCart.TabIndex = 5;
            this.btnAddtoCart.Text = "Add to Cart\r\n>>";
            this.btnAddtoCart.UseVisualStyleBackColor = false;
            this.btnAddtoCart.Click += new System.EventHandler(this.button3_Click);
            // 
            // picToy
            // 
            this.picToy.Location = new System.Drawing.Point(6, 35);
            this.picToy.Name = "picToy";
            this.picToy.Size = new System.Drawing.Size(217, 146);
            this.picToy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picToy.TabIndex = 6;
            this.picToy.TabStop = false;
            // 
            // lblToyName
            // 
            this.lblToyName.Location = new System.Drawing.Point(289, 42);
            this.lblToyName.Name = "lblToyName";
            this.lblToyName.Size = new System.Drawing.Size(113, 40);
            this.lblToyName.TabIndex = 7;
            this.lblToyName.Text = "Name :";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(297, 144);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 16);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Price :";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(566, 408);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 76);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(817, 551);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddtoCart);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.ItemsDetails);
            this.Controls.Add(this.MyCart);
            this.Controls.Add(this.Toylst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ItemsDetails.ResumeLayout(false);
            this.ItemsDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picToy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Toylst;
        private System.Windows.Forms.ListBox MyCart;
        private System.Windows.Forms.GroupBox ItemsDetails;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnAddtoCart;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblToyName;
        private System.Windows.Forms.PictureBox picToy;
        private System.Windows.Forms.Button btnClear;
    }
}

