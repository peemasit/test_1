using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace test_1 {
    public partial class Inventory : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            
            if (!IsPostBack) {
                bindDataCar();
            }
        }
        void bindDataCar() {
            CarRepository carRepository = new CarRepository();
            gvCar.DataSource = carRepository.showCarList();
            gvCar.DataBind();
        }
    }
}