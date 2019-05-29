using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static test_1.CarRepository;

namespace test_1 {
    public partial class CarType : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void addBtn_Click(object sender, EventArgs e) {
            CarRepository carRepository = new CarRepository();
            carModel data = new carModel() {
                carId = idTxt.Text,
                carName = nameTxt.Text
            };
            carRepository.AddCarType(data);
            Response.Redirect("Inventory.aspx");
        }
    }
}