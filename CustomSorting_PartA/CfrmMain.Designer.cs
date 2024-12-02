
namespace CustomSorting
{
    partial class CfrmMain
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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblValue = new System.Windows.Forms.Label();
            this.mlstbxObjects = new CustomSorting.MementoListBox();
            this.btnUndo = new System.Windows.Forms.Button();
            this.lblStackCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(168, 25);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(43, 16);
            this.lblValue.TabIndex = 1;
            this.lblValue.Text = "Value";
            // 
            // mlstbxObjects
            // 
            this.mlstbxObjects.Dock = System.Windows.Forms.DockStyle.Left;
            this.mlstbxObjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mlstbxObjects.FormattingEnabled = true;
            this.mlstbxObjects.ItemHeight = 25;
            this.mlstbxObjects.Location = new System.Drawing.Point(0, 0);
            this.mlstbxObjects.Name = "mlstbxObjects";
            this.mlstbxObjects.Size = new System.Drawing.Size(148, 200);
            this.mlstbxObjects.TabIndex = 2;
            this.mlstbxObjects.DragDrop += new System.Windows.Forms.DragEventHandler(this.mlstbxObjects_DragDrop);
            this.mlstbxObjects.DragOver += new System.Windows.Forms.DragEventHandler(this.mlstbxObjects_DragOver);
            this.mlstbxObjects.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mlstbxObjects_MouseDown);
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(171, 144);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 23);
            this.btnUndo.TabIndex = 3;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // lblStackCount
            // 
            this.lblStackCount.AutoSize = true;
            this.lblStackCount.Location = new System.Drawing.Point(168, 170);
            this.lblStackCount.Name = "lblStackCount";
            this.lblStackCount.Size = new System.Drawing.Size(79, 16);
            this.lblStackCount.TabIndex = 4;
            this.lblStackCount.Text = "Stack.Count";
            // 
            // CfrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 200);
            this.Controls.Add(this.lblStackCount);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.mlstbxObjects);
            this.Controls.Add(this.lblValue);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CfrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom sorting (Part A)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblValue;
        private MementoListBox mlstbxObjects;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Label lblStackCount;
    }
}

