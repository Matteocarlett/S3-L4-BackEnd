using System;

namespace WebApplication4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ddlCarModels_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCarDetails();
        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void UpdateCarDetails()
        {

            imgCar.Visible = true;
            litBasePrice.Visible = true;
            litBasePrice.Text = GetBasePrice(ddlCarModels.SelectedValue); 
        }

        private void CalculateTotal()
        {
            double basePrice = Convert.ToDouble(litBasePrice.Text.Substring(litBasePrice.Text.IndexOf(":") + 2, litBasePrice.Text.IndexOf("EUR") - (litBasePrice.Text.IndexOf(":") + 2)));
            double totalPrice = basePrice;
            litResult.Text = "<h3>Dettagli Preventivo</h3>";

            double option1Price = 3500;
            double option2Price = 700;
            double option3Price = 1300;
            double option4Price = 1500;
            double option5Price = 1000;
            double option6Price = 1600;

            if (cbxOption1.Checked)
            {
                totalPrice += option1Price;
                litResult.Text += $"<p>Pacchetto sportivo: {option1Price} EUR</p>";
            }
            if (cbxOption2.Checked)
            {
                totalPrice += option2Price;
                litResult.Text += $"<p>Cerchi in lega: {option2Price} EUR</p>";
            }
            if (cbxOption3.Checked)
            {
                totalPrice += option3Price;
                litResult.Text += $"<p>Interni in pelle: {option3Price} EUR</p>";
            }
            if (cbxOption4.Checked)
            {
                totalPrice += option4Price;
                litResult.Text += $"<p>Sistema di navigazione GPS: {option4Price} EUR</p>";
            }
            if (cbxOption5.Checked)
            {
                totalPrice += option5Price;
                litResult.Text += $"<p>Fari allo xeno: {option5Price} EUR</p>";
            }
            if (cbxOption6.Checked)
            {
                totalPrice += option6Price;
                litResult.Text += $"<p>Sedili riscaldati: {option6Price} EUR</p>";
            }

            // Calcola il totale della garanzia

            if (ddlWarranty.SelectedIndex > 0)
            {
                int years = int.Parse(ddlWarranty.SelectedValue);
                double warrantyPrice = years * 120;
                totalPrice += warrantyPrice;
                litResult.Text += $"<p>Garanzia ({years} anni): {warrantyPrice} EUR</p>";
            }

            litResult.Text += $"<p><strong>Totale Prezzo di Base:</strong> {basePrice} EUR</p>";
            litResult.Text += $"<p><strong>Totale Optional:</strong> {totalPrice - basePrice} EUR</p>";
            litResult.Text += $"<p><strong>Totale Garanzia:</strong> {totalPrice - basePrice} EUR</p>";
            litResult.Text += $"<p><strong>Totale Complessivo:</strong> {totalPrice} EUR</p>";
        }

        private string GetBasePrice(string carModel)
        {
            //  prezzo dal database fittizio

            switch (carModel)
            {
                case "Modello1":
                    return "Prezzo di base: 52.000 EUR";
                case "Modello2":
                    return "Prezzo di base: 48.000 EUR";
                case "Modello3":
                    return "Prezzo di base: 30.000 EUR";
                case "Modello4":
                    return "Prezzo di base: 14.000 EUR";
                case "Modello5":
                    return "Prezzo di base: 24.000 EUR";
                case "Modello6":
                    return "Prezzo di base: 82.000 EUR";
                default:
                    return "Prezzo di base non disponibile";
            }
        }
    }
}
