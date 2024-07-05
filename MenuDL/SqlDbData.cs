using MenuModels;
using System.Data.SqlClient;

namespace MenuDL
{
    public class SqlDbData
    {
        string connectionString
        = "Data Source =ELIJAH\\MSSQLSERVER01; Initial Catalog = MenuPlan; Integrated Security = True;";

        SqlConnection sqlConnection;

        public SqlDbData()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public List<Menu> GetMenus()
        {
            string selectStatement = "SELECT Meal, Dish, Code FROM Menu";

            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);

            sqlConnection.Open();
            List<Menu> menus = new List<Menu>();

            SqlDataReader reader = selectCommand.ExecuteReader();

            while (reader.Read())
            {
                string Meal = reader["Meal"].ToString();
                string Dish = reader["Dish"].ToString();
                string Code = reader["Code"].ToString();

                Menu readMenu = new Menu();
                readMenu.Meal = Meal;
                readMenu.Dish = Dish;
                readMenu.Code = Code;

                menus.Add(readMenu);

            }
            sqlConnection.Close();

            return menus;

        }

        public int AddMenu(string Meal, string Dish, string Code)
        {
            int success;

            string insertStatement = "INSERT INTO Menu VALUES(@Meal, @Dish, @Code)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);

            insertCommand.Parameters.AddWithValue("@Meal", Meal);
            insertCommand.Parameters.AddWithValue("@Dish", Dish);
            insertCommand.Parameters.AddWithValue("@Code", Code);

            sqlConnection.Open();

            success = insertCommand.ExecuteNonQuery();


            sqlConnection.Close();

            return success;

        }

        public int UpdateMenu(string Meal, string Dish, string Code)
        {
            int success;

            string updateStatement = $"UPDATE Menu SET Code = @Code WHERE Meal = @Meal";
            SqlCommand updateCommand = new SqlCommand(updateStatement, sqlConnection);
            sqlConnection.Open();

            updateCommand.Parameters.AddWithValue("@Meal", Meal);
            updateCommand.Parameters.AddWithValue("@Code", Code);

            success = updateCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return success;
        }

        public int DeleteMenu(string Meal, string Dish, string Code)
        {
            int success;

            string deleteStatement = $"UPDATE FROM Menu WHERE Meal = @Meal, Dish = @Dish, Code = @Code";
            SqlCommand deleteCommand = new SqlCommand(deleteStatement, sqlConnection);
            sqlConnection.Open();

            deleteCommand.Parameters.AddWithValue("@Meal", Meal);
            deleteCommand.Parameters.AddWithValue("@Dish", Dish);
            deleteCommand.Parameters.AddWithValue("@Code", Code);

            success = deleteCommand.ExecuteNonQuery();

            sqlConnection.Close();

            return success;
        }


    }
}