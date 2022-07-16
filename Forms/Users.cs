using CashRegister.Libraries.Core.Service;
using CashRegister.Libraries.Database.Entity;
using CashRegister.Libraries.DataStructs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashRegister.Applications.Winform.WFVPos.Forms
{
    public partial class Users : Form
    {
        private static List<DataContractUsers> lstUsers;
        private string Username { get; set; }
        String idUser;
        public Users()
        {
            InitializeComponent();
            GlobalInformation.Instance.TagData = string.Empty;



            UsersCore usersCore = new UsersCore();
            lstUsers = usersCore.GetAllUsersNameToList();
            
            SetViewBagData();
        }

        private void SetViewBagData()
        {
            DataTable table = new DataTable();
            table.Columns.Add("id", typeof(string));
            table.Columns.Add("id_persona", typeof(string));
            table.Columns.Add("Usuario", typeof(string));
            table.Columns.Add("Identificacion", typeof(string));
            table.Columns.Add("Nombres", typeof(string));
            table.Columns.Add("Apellidos", typeof(string));
            table.Columns.Add("Teléfono", typeof(string));
            table.Columns.Add("Dirección", typeof(string));
            table.Columns.Add("Correo", typeof(string));
            table.Columns.Add("Fecha Creación", typeof(string));
            table.Columns.Add("Rol", typeof(string));

            foreach(DataContractUsers us in lstUsers)
            {
                table.Rows.Add(us.user_id, us.person_id, us.nickname, us.identification, us.name, us.last_name, us.phone,
                    us.address, us.email, us.user_creation_date, us.role_name);
            }
            //this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = table;
            this.dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.Columns[1].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                idUser= this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                this.nickname.Text = this.dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.identification.Text= this.dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                this.name.Text = this.dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                this.last_name.Text = this.dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                this.phone.Text = this.dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                this.address.Text = this.dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                this.email.Text = this.dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                if (this.dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString() == "Admin")
                {
                    this.role_name.SelectedItem = "Administrador";
                }
                else
                {
                    this.role_name.SelectedItem = "Usuario";
                }
                
            }
        }

        private void guardarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                DisableWidgets();

                DataContractUsers user = null;
            long uniqueId = Convert.ToInt32(idUser);
            UsersCore usersCore = new UsersCore();
            if (uniqueId == 0)
            {
                user = new DataContractUsers();
                user.nickname = this.nickname.Text;
                if (this.role_name.Text == "Administrador")
                {
                    user.role_id = 1;
                }
                else
                {
                    user.role_id = 2;
                }
                
                user.identification = this.identification.Text;
                user.name = this.name.Text;
                user.last_name = this.last_name.Text;
                user.phone = this.phone.Text;
                user.address = this.address.Text;
                user.email = this.email.Text;
                usersCore.SaveNewUserPerson(user);
                    MessageBox.Show("Se grabó correctamente el usuario");
                }

            else
            {
                foreach (DataContractUsers item in lstUsers)
                {
                    if (item.user_id == uniqueId)
                    {
                        user = item;
                        user.nickname = this.nickname.Text;
                        if (this.role_name.Text == "Administrador")
                        {
                            user.role_id = 1;
                        }
                        else
                        {
                            user.role_id = 2;
                        }
                        user.identification = this.identification.Text;
                        user.name = this.name.Text;
                        user.last_name = this.last_name.Text;
                        user.phone = this.phone.Text;
                        user.address = this.address.Text;
                        user.email = this.email.Text;
                        break;
                    }
                }
                if (user == null)
                    throw new Exception("Unknow user_id");

                usersCore.UpdateUserPerson(user);
                    MessageBox.Show("La información se actualizó correctamente");
                }

                //No se a que hace referencia y si es necesario
                //GlobalInformation.Instance.TagData = "8013";//para no exigir la contraseña porque ya esta dentro
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message, "VPOS Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                EnableWidgets();
            }
        }

        private void DisableWidgets()
        {
            pnlMain.Enabled = false;
            limpiar.Enabled = false;


        }

        private void EnableWidgets()
        {
            pnlMain.Enabled = true;
            limpiar.Enabled = true;
        }

        private void RefreshPass_Click(object sender, EventArgs e)
        {
            try
            {
                DisableWidgets();
                string user_id = idUser ;
                UsersCore usersCore = new UsersCore();
                usersCore.RefreshUserPasswordByUniqueId(Convert.ToInt32(user_id));
                MessageBox.Show("La contraseña fue generada exitosamente");
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message, "VPOS Control", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                EnableWidgets();
            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            Dashboard f = new Dashboard();
            f.Show();
        }
    }
}
