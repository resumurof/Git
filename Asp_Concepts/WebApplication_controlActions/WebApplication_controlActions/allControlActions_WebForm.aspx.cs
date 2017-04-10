using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Configuration;
using System.Data;

namespace WebApplication_controlActions
{
    public partial class allControlActions_WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            continentsDropDownList.DataSource = GetData("spGetContinents", null);
            continentsDropDownList.DataTextField = "ContinentName";
            continentsDropDownList.DataValueField = "ContinentId";
            continentsDropDownList.DataBind();
           
        }

        private DataSet GetData(String spName, SqlParameter param)
        {
           String str = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
           using(SqlConnection con = new SqlConnection(str))
           {
              
               SqlDataAdapter da = new SqlDataAdapter(spName, con);
               if (param != null)
               {
                   da.SelectCommand.Parameters.Add(param);
               }
               da.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
               DataSet ds = new DataSet();
               da.Fill(ds);
               return ds;
           }
        }

        protected void onSelectionChanged(object sender, EventArgs e)
        {
             if(continentsDropDownList.SelectedIndex > 0)
             {
                 SqlParameter parameter = new SqlParameter();
                 parameter.ParameterName = "@ContinentId";
                 parameter.Value = continentsDropDownList.SelectedValue;

                 countriesDropDownList.DataSource = GetData("spGetCountriesByContinentId", parameter);
                 countriesDropDownList.DataTextField = "CountryName";
                 countriesDropDownList.DataValueField = "CountryId";
                 countriesDropDownList.DataBind();

             }
        }

        protected void onCountriesSelectionChanged(object sender, EventArgs e)
        {
            if (countriesDropDownList .SelectedIndex > 0)
            {
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@CountryId";
                parameter.Value = countriesDropDownList.SelectedValue;

                citiesDropDownList.DataSource = GetData("spGetCitiesByCountryId", parameter);
                citiesDropDownList.DataTextField = "CityName";
                citiesDropDownList.DataValueField = "CityId";
                citiesDropDownList.DataBind();

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            foreach (ListItem cb in CheckBoxListCollection.Items)
            {
                cb.Selected = true;
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            foreach (ListItem li in CheckBoxListCollection.Items)
            {
                li.Selected = false;
            }
        }

        protected void OK_Click(object sender, EventArgs e)
        {

        }
    }
}