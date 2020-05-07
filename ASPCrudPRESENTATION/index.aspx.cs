using LIBCrudAPPLICATIONS.Controllers;
using LIBCrudDATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPCrudPRESENTATION
{
    public partial class Home : System.Web.UI.Page
    {
        public static Home HomeRegistration;
        private UsersController UsersController;

        public Home()
        {
            Home.HomeRegistration = this;
            UsersController = new UsersController();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                var list = UsersController.List();
                if (list == null)
                {
                    txMessage.Text = UsersController.Exception.ToString();
                    return;
                }
                this.dgList.DataSource = list;
                this.dgList.DataBind();
            }
            catch (Exception ex)
            {
                txMessage.Text = ex.ToString();
            }
        }
        protected void btSelect_Click(object sender, EventArgs e)
        {
            try
            {
                var idSelected = txSelected.Text.Trim();
                var getListClick = UsersController.GetUser(idSelected);
                if (getListClick == null)
                {
                    txMessage.Text = UsersController.Exception.ToString();
                    return;
                }
                txId.Text = getListClick[0].Id.ToString();
                txName.Text = getListClick[0].Name.ToString();
                txPassword.Text = getListClick[0].Password.ToString();
                txState.Checked = getListClick[0].State;
                txDocument.Text = getListClick[0].Document.ToString();
                txSelected.Text = "";
            }
            catch (Exception ex)
            {
                txMessage.Text = ex.ToString();
            }
        }
        protected void btAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var user = new Users();
                user.Name = txName.Text.Trim();
                user.Password = txPassword.Text.Trim();
                user.State = txState.Checked;
                user.Document = txDocument.Text.Trim();

                if (!UsersController.Add(user))
                {
                    txMessage.Text = UsersController.Exception.ToString();
                }
                else
                {
                    Clear(sender, e);
                    txMessage.Text = "Usuario ingresado exitosamente";
                }
            }
            catch (Exception ex)
            {
                txMessage.Text = ex.ToString();
            }
        }

        protected void btUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var user = new Users();
                user.Id = Convert.ToInt32(txId.Text.Trim());
                user.Name = txName.Text.Trim();
                user.Password = txPassword.Text.Trim();
                user.State = txState.Checked;
                user.Document = txDocument.Text.Trim();
                if (!UsersController.Update(user))
                {
                    txMessage.Text = UsersController.Exception.ToString();
                }
                else
                {
                    Clear(sender, e);
                    txMessage.Text = "Usuario actualizado exitosamente";
                }
            }
            catch (Exception ex)
            {
                txMessage.Text = ex.ToString();
            }
        }

        protected void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var userId = txId.Text.Trim();
                if (!UsersController.Delete(userId))
                {
                    txMessage.Text = UsersController.Exception.ToString();
                }
                else
                {
                    Clear(sender, e);
                    txMessage.Text = "Usuario actualizado exitosamente";
                }
            }
            catch (Exception ex)
            {
                txMessage.Text = ex.ToString();
            }
        }

        private void Clear(object sender, EventArgs e)
        {
            txId.Text = "";
            txName.Text = "";
            txPassword.Text = "";
            txDocument.Text = "";
            txState.Checked = false;
            Page_Load(sender, e);
        }
    }
}