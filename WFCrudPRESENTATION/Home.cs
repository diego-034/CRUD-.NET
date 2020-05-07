using LIBCrudAPPLICATIONS.Controllers;
using LIBCrudDATA.Models;
using System;
using System.Windows.Forms;

namespace WFCrudPRESENTATION
{
    public partial class Home : Form
    {
        public static Home HomeRegistration;
        private UsersController UsersController;

        public Home()
        {
            InitializeComponent();
            Home.HomeRegistration = this;
            UsersController = new UsersController();
        }
        
        private void HomeRegistration_Load(object sender, EventArgs e)
        {
            try
            {
                var list = UsersController.List();
                if (list == null)
                {
                    MessageBox.Show(UsersController.Exception.ToString());
                    return;
                }
                this.dgList.DataSource = list;
                this.dgList.Refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void dgListCellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var idSelected = dgList.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                var getListClick = UsersController.GetUser(idSelected);
                if (getListClick == null)
                {
                    MessageBox.Show(UsersController.Exception.ToString());
                    return;
                }
                txId.Text = getListClick[0].Id.ToString();
                txName.Text = getListClick[0].Name.ToString();
                txPassword.Text = getListClick[0].Password.ToString();
                txState.Text = getListClick[0].State == true ? "Activo":"Inactivo";
                txDocument.Text = getListClick[0].Document.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var user = new Users();
                user.Name = txName.Text.Trim();
                user.Password = txPassword.Text.Trim();
                user.State = txState.Text.Trim() == "Activo" ? true : false;
                user.Document = txDocument.Text.Trim();

                if (!UsersController.Add(user))
                {
                    MessageBox.Show(UsersController.Exception.ToString());
                }
                else
                {
                    Clear(sender,e);
                    MessageBox.Show("Usuario ingresado exitosamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var user = new Users();
                user.Id = Convert.ToInt32(txId.Text.Trim());
                user.Name = txName.Text.Trim();
                user.Password = txPassword.Text.Trim();
                user.State = txState.Text.Trim() == "Activo" ? true : false;
                user.Document = txDocument.Text.Trim();
                if (!UsersController.Update(user))
                {
                    MessageBox.Show(UsersController.Exception.ToString());
                }
                else
                {
                    Clear(sender,e);
                    MessageBox.Show("Usuario actualizado exitosamente");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var userId = txId.Text.Trim();
                if (!UsersController.Delete(userId))
                {
                    MessageBox.Show(UsersController.Exception.ToString());
                }
                else
                {
                    Clear(sender, e);
                    MessageBox.Show("Usuario actualizado exitosamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Clear(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                    control.ResetText();
            }
            HomeRegistration_Load(sender, e);
        }
    }
}
