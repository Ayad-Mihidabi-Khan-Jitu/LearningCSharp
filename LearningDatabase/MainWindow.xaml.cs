using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LearningDatabase
    {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
        {
        SqlConnection sqlConnection;
        public MainWindow()
            {
            InitializeComponent();

            ///1. ConnectionString of the Database
            //SYNTEX: ConfigurationManager.ConnectionStrings["Project_Name.Properties.Settings.Name_of_connection"].ConnectionString;
            string connectionString = ConfigurationManager.ConnectionStrings["LearningDatabase.Properties.Settings.ZooDBConnectionString"].ConnectionString;

            ///2. Connecting to the server
            ///SYNTEX: Connection_name = new SqlConnection(connectionString);
            sqlConnection = new SqlConnection(connectionString);

            ShowZoo();
            }

        private void ShowZoo()
            {
            try
                {
                string query = "select * from Zoo";
                ///3. Query Excuting using the database connection
                ///SYNTEX: SqlDataAdapter Name_of_Data = new SqlDataAdapter(query, sqlConnection);
                //sqlDataAdapter can be imagined like an Interface to make Tables usable by C# Objects
                //-sqlDataAdapter takes care of open and close tha database connection
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

                using (sqlDataAdapter)
                    {
                    ///4. Creating a Table for containing the data of the queried sqlDataAdapter
                    DataTable zooTable = new DataTable();
                    ///5. Filling the Table with the query data
                    sqlDataAdapter.Fill(zooTable);

                    //which information of the Table in DataTable should be show in our ListBox
                    listZoo.DisplayMemberPath = "Location";

                    //which value should be delivered when an item from the ListBox is selected
                    listZoo.SelectedValuePath = "Id";

                    //The Reference to the Data the ListBox should populate 
                    listZoo.ItemsSource = zooTable.DefaultView;
                    }
                }
            catch (Exception e)
                {
               MessageBox.Show(e.ToString());
                }
            }
        }
    }
