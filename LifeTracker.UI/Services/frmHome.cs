using LifeTracker.Core.BLL;
using System;
using System.Windows.Forms;

namespace LifeTracker.UI.Services
{
    public partial class frmHome : Form {

        private DietBLL _dietBLL;
        
        public frmHome() {
            InitializeComponent();
            _dietBLL = new DietBLL();

            Initialize();            
        }

        public void Initialize() {
            SetPieChartData2Canvas();
            SetDoughnutChartData2Canvas();
            SetBarChartData2Canvas();
        }


        // 1er chart => Pie chart c/ Grasas, Proteínas, Calorías (del día)
        // 2do chart => Pie chart c/ Porcentajes por tipo de comida (del día)
        // 3er chart => Bar chart c/ Calorías por día de toda la semana
        #region [ Pie Chart - Fat, Protein & Calories of the Day ]
        public void SetPieChartData2Canvas() {
            var fat = _dietBLL.GetAllTodaysFat();
            var protein = _dietBLL.GetAllTodaysProtein();
            var calories = _dietBLL.GetAllTodaysCalories();

            pieChart.Data.Clear();
            pieChart.Data.Add(Convert.ToDouble(fat));
            pieChart.Data.Add(Convert.ToDouble(protein));
            pieChart.Data.Add(Convert.ToDouble(calories));
        }
        #endregion

        #region [ Doughnut Chart - Meals of the Day ]
        public void SetDoughnutChartData2Canvas() {
            var data = _dietBLL.GetAllTodaysMeals();

            mealChart.Data.Clear();
            mealChart.Data.AddRange(data);
        }

        public void SetBarChartData2Canvas() {
            var data = _dietBLL.GetAllDatesOfWeek();

            barChart.Data.Clear();
            barChart.Data.AddRange(data);
        }

        private void SetNewRange2BarChart() {
            string[] legends;
            //barChartCanvas
        }
        #endregion

    }
}
