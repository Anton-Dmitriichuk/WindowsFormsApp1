using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public Form1()
        {
            InitializeComponent();
            connection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Антон Дмитрийчук\\Desktop\\интерфейсы\\WindowsFormsApp1\\Database1.mdb;Persist Security Info=True";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new OleDbConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);

            connection.Open();

            if ( connection.State == ConnectionState.Open )
            {
                MessageBox.Show("Подключился");
            } 
            else
            {
                MessageBox.Show("NO Подключился");
            }
        }

        private void add_client_button_Click(object sender, EventArgs e)
        {
            try
            {
                
                OleDbCommand command_add_client = new OleDbCommand();
                command_add_client.Connection = connection;
                command_add_client.CommandText = "INSERT INTO Пациенты(Код_пациента, Имя, Фамилия, Отчество, Контингент," +
                    "Дата_рождения, Серия_паспорта, Номер_паспорта, Адрес_проживания, Номер_телефона)" +
                    "VALUES(@id, @name, @familia, @otchestvo, @contingent, @dob, @sp, @np, @address, @phone)";
                connection.Open();
                command_add_client.Parameters.Add("@id", OleDbType.SmallInt).Value = textBox1.Text;
                command_add_client.Parameters.Add("@name", OleDbType.WChar).Value = client_name.Text;
                command_add_client.Parameters.Add("@familia", OleDbType.WChar).Value = client_surname.Text;
                command_add_client.Parameters.Add("@otchestvo", OleDbType.WChar).Value = client_patronymic.Text;
                command_add_client.Parameters.Add("@contingent", OleDbType.WChar).Value = client_contingent.Text;
                command_add_client.Parameters.Add("@dob", OleDbType.Date).Value = client_date_of_birth.Text;
                command_add_client.Parameters.Add("@sp", OleDbType.SmallInt).Value = client_series_passport.Text;
                command_add_client.Parameters.Add("@np", OleDbType.SmallInt).Value = client_num_passport.Text;
                command_add_client.Parameters.Add("@address", OleDbType.WChar).Value = client_address.Text;
                command_add_client.Parameters.Add("@phone", OleDbType.WChar).Value = client_phone.Text;
                command_add_client.ExecuteNonQuery();
                connection.Close();
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("err" + ex);
            }
            
        }
    }
}


//{Convert.ToInt32(textBox1.Text)}

/*
public partial class Form1 : Form
{
    private OleDbConnection connection = null;
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        connection = new OleDbConnection(ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString);

        connection.Open();

        if (connection.State == ConnectionState.Open)
        {
            MessageBox.Show("Подключился");
        }
        else
        {
            MessageBox.Show("NO Подключился");
        }
    }

    private void add_client_button_Click(object sender, EventArgs e)
    {
        try
        {
            OleDbCommand command_add_client = new OleDbCommand($"INSERT INTO Пациенты (Код_пациента, Имя, Фамилия, Отчество, " +
                            "Контингент, Дата_рождения, Серия_паспорта, Номер_паспорта, Адрес_проживания, Номер_телефона)" +
                            $"VALUES ({textBox1.Text}, {client_name.Text}, {client_surname.Text}, " +
                            $"{client_patronymic.Text}, {client_contingent.Text}, {client_date_of_birth.Text}, " +
                            $"{client_series_passport.Text}, " +
                            $"{client_num_passport.Text}, {client_address.Text}, {client_phone.Text})", connection);



            command_add_client.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            MessageBox.Show("err" + ex);
        }

    }
}
*/



/*
    connection.Open();
    OleDbCommand command_add_client = new OleDbCommand();
    command_add_client.Connection = connection;
    command_add_client.CommandText = "INSERT INTO Пациенты (Имя, Фамилия, Отчество, Контингент, Дата_рождения, Серия_паспорта, Номер_паспорта, Адрес_проживания, Номер_телефона) VALUES('"+ client_name.Text +"','"+ client_surname.Text +"','" + client_patronymic.Text+"','"+client_contingent.Text+"','"+client_date_of_birth.Text+"','" +client_series_passport.Text+"','"+client_num_passport.Text+"','"+client_address.Text+"','"+client_phone.Text+"')";


    command_add_client.ExecuteNonQuery();
    connection.Close(); 
 */