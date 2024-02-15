<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Car Quotation</title>
    <style>
        .container {
            width: 30%;
            margin: 0 auto;
            height: 331px;
        }

        .option {
            margin: 7px;
        }

        #ddlCarModels {
            margin: 10px;
        }

        .yearsG {
            margin-bottom: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Creazione Preventivo</h2>
            <div>
                <label for="ddlCarModels">Seleziona un'auto:</label>
                <asp:DropDownList ID="ddlCarModels" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCarModels_SelectedIndexChanged">
                    <asp:ListItem Text="-- Seleziona --" Value="" />
                    <asp:ListItem Text="Audi A5 Coupé" Value="Modello1" />
                    <asp:ListItem Text="BMW S5 Touring" Value="Modello2" />
                    <asp:ListItem Text="Ford Puma" Value="Modello3" />
                    <asp:ListItem Text="Toyota Yaris" Value="Modello4" />
                    <asp:ListItem Text="Volkswagen Polo" Value="Modello5" />
                    <asp:ListItem Text="Audi Q8" Value="Modello6" />
                </asp:DropDownList>
            </div>
            <div>
                <asp:Image ID="imgCar" runat="server" Visible="false" />
                <asp:Literal ID="litBasePrice" runat="server" Visible="false" />
            </div>
            <div class="option">
                <label for="cbxOption1">
                    <asp:CheckBox ID="cbxOption1" runat="server" Text="Pacchetto sportivo" />
                </label>
            </div>
            <div class="option">
                <label for="cbxOption2">
                    <asp:CheckBox ID="cbxOption2" runat="server" Text="Cerchi in lega" />
                </label>
            </div>
            <div class="option">
                <label for="cbxOption3">
                    <asp:CheckBox ID="cbxOption3" runat="server" Text="Interni in pelle" />
                </label>
            </div>
            <div class="option">
                <label for="cbxOption4">
                    <asp:CheckBox ID="cbxOption4" runat="server" Text="Sistema di navigazione GPS" />
                </label>
            </div>
            <div class="option">
                <label for="cbxOption5">
                    <asp:CheckBox ID="cbxOption5" runat="server" Text="Fari allo xeno" />
                </label>
            </div>
            <div class="option">
                <label for="cbxOption6">
                    <asp:CheckBox ID="cbxOption6" runat="server" Text="Sedili riscaldati" />
                </label>
            </div>


            <div class="yearsG">
                <label for="ddlWarranty">Anni di Garanzia:</label>
                <asp:DropDownList ID="ddlWarranty" runat="server">
                    <asp:ListItem Text="-- Seleziona --" Value="" />
                    <asp:ListItem Text="1 anno" Value="1" />
                    <asp:ListItem Text="2 anni" Value="2" />
                    <asp:ListItem Text="3 anni" Value="3" />
                </asp:DropDownList>
            </div>
            <div>
                <asp:Button ID="btnCalculate" runat="server" Text="Calcola Preventivo" OnClick="btnCalculate_Click" />
            </div>
            <hr />
            <div>
                <asp:Literal ID="litResult" runat="server" />
            </div>

        </div>
    </form>
</body>
</html>
