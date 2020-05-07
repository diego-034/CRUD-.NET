namespace WFCrudPRESENTATION
{
    partial class Home
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbState = new System.Windows.Forms.Label();
            this.lbDocument = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.txId = new System.Windows.Forms.TextBox();
            this.txName = new System.Windows.Forms.TextBox();
            this.txPassword = new System.Windows.Forms.TextBox();
            this.txDocument = new System.Windows.Forms.TextBox();
            this.txState = new System.Windows.Forms.ComboBox();
            this.btUpdate = new System.Windows.Forms.Button();
            this.dgList = new System.Windows.Forms.DataGridView();
            this.btDelete = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("MV Boli", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(216, 28);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(313, 125);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "CRUD";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(31, 177);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(44, 13);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Nombre";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(212, 177);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(61, 13);
            this.lbPassword.TabIndex = 2;
            this.lbPassword.Text = "Contraseña";
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.Location = new System.Drawing.Point(412, 177);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(40, 13);
            this.lbState.TabIndex = 3;
            this.lbState.Text = "Estado";
            // 
            // lbDocument
            // 
            this.lbDocument.AutoSize = true;
            this.lbDocument.Location = new System.Drawing.Point(584, 177);
            this.lbDocument.Name = "lbDocument";
            this.lbDocument.Size = new System.Drawing.Size(87, 13);
            this.lbDocument.TabIndex = 4;
            this.lbDocument.Text = "# de Documento";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(31, 115);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(16, 13);
            this.lbId.TabIndex = 5;
            this.lbId.Text = "Id";
            // 
            // txId
            // 
            this.txId.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.txId.Enabled = false;
            this.txId.Location = new System.Drawing.Point(53, 112);
            this.txId.Name = "txId";
            this.txId.ReadOnly = true;
            this.txId.Size = new System.Drawing.Size(36, 20);
            this.txId.TabIndex = 6;
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(81, 174);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(125, 20);
            this.txName.TabIndex = 7;
            // 
            // txPassword
            // 
            this.txPassword.Location = new System.Drawing.Point(279, 174);
            this.txPassword.Name = "txPassword";
            this.txPassword.Size = new System.Drawing.Size(125, 20);
            this.txPassword.TabIndex = 8;
            // 
            // txDocument
            // 
            this.txDocument.Location = new System.Drawing.Point(677, 174);
            this.txDocument.Name = "txDocument";
            this.txDocument.Size = new System.Drawing.Size(125, 20);
            this.txDocument.TabIndex = 9;
            // 
            // txState
            // 
            this.txState.FormattingEnabled = true;
            this.txState.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.txState.Location = new System.Drawing.Point(458, 174);
            this.txState.Name = "txState";
            this.txState.Size = new System.Drawing.Size(121, 21);
            this.txState.TabIndex = 10;
            // 
            // btUpdate
            // 
            this.btUpdate.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.Location = new System.Drawing.Point(349, 256);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(257, 58);
            this.btUpdate.TabIndex = 11;
            this.btUpdate.Text = "Actualizar";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // dgList
            // 
            this.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgList.Location = new System.Drawing.Point(34, 359);
            this.dgList.Name = "dgList";
            this.dgList.Size = new System.Drawing.Size(572, 214);
            this.dgList.TabIndex = 12;
            this.dgList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListCellClick);
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.Location = new System.Drawing.Point(657, 515);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(174, 58);
            this.btDelete.TabIndex = 13;
            this.btDelete.Text = "Eliminar";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Location = new System.Drawing.Point(62, 256);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(183, 58);
            this.btAdd.TabIndex = 14;
            this.btAdd.Text = "Agregar";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 633);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.dgList);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.txState);
            this.Controls.Add(this.txDocument);
            this.Controls.Add(this.txPassword);
            this.Controls.Add(this.txName);
            this.Controls.Add(this.txId);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.lbDocument);
            this.Controls.Add(this.lbState);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbTitle);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.HomeRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.Label lbDocument;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox txId;
        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.TextBox txPassword;
        private System.Windows.Forms.TextBox txDocument;
        private System.Windows.Forms.ComboBox txState;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.DataGridView dgList;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAdd;
    }
}