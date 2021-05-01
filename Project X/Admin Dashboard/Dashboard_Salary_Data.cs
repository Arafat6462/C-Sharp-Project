using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_X
{
    class Dashboard_Salary_Data
    {

        // database connection
        DatabaseConnection databaseConnection = new DatabaseConnection();
        string query;
        // salary input value
       public ArrayList IDList = new ArrayList();
       public ArrayList NameList = new ArrayList();
       public ArrayList SalaryList = new ArrayList();

       public int TotalAmount = 500000;

        /// <summary>
        /// //load data from db to array list
        /// </summary>
        public void loadDAtaToArrayList()
        {
             query = "select eid, ename, esalary from employee";
            DataSet dataSet = databaseConnection.getData(query);
 
           // selection the value from db and store
            for(int i=0; i<dataSet.Tables[0].Rows.Count; i++)
            {
               IDList.Add(dataSet.Tables[0].Rows[i][0].ToString());
               NameList.Add(dataSet.Tables[0].Rows[i][1].ToString());
               SalaryList.Add(dataSet.Tables[0].Rows[i][2].ToString());
             }

         }
    }
}
