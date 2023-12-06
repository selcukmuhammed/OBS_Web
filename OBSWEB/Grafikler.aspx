<%@ Page Title="" Language="C#" MasterPageFile="~/Ogretmen.Master" AutoEventWireup="true" CodeBehind="Grafikler.aspx.cs" Inherits="OBSWEB.Grafikler" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">



    <form id="form1" runat="server">
        <table class="table table-bordered table-hover">
            <tr>
                <td>
                    <asp:Chart ID="Chart1" runat="server" Height="296px" Width="412px"
                        BorderDashStyle="Solid" BackSecondaryColor="White"
                        BackGradientStyle="TopBottom" BorderWidth="2px" BackColor="211, 223, 240"
                        BorderColor="#1A3B69">
                        <Series>
                            <asp:Series Name="Branş">
                            </asp:Series>
                        </Series>
                        <ChartAreas>
                            <asp:ChartArea Name="ChartArea1">
                            </asp:ChartArea>
                        </ChartAreas>
                    </asp:Chart>
                </td>
                <td>
                    <asp:Chart ID="Chart2" runat="server" Width="500px" Palette="Chocolate" BackSecondaryColor="White" >
                        <Series>
                            <asp:Series Name="Notlar" ChartType="Area">
                            </asp:Series>
                        </Series>
                        <ChartAreas>
                            <asp:ChartArea Name="ChartArea1">
                            </asp:ChartArea>
                        </ChartAreas>
                    </asp:Chart>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Chart ID="Chart3" runat="server" Width="500px" Palette="Fire">
                        <Series>
                            <asp:Series Name="Dersler" ChartType="Pie">
                            </asp:Series>
                        </Series>
                        <ChartAreas>
                            <asp:ChartArea Name="ChartArea1">
                            </asp:ChartArea>
                        </ChartAreas>
                    </asp:Chart>
                </td>
                <td>
                    <asp:Chart ID="Chart4" runat="server" Width="500px" Palette="Excel">
                        <Series>
                            <asp:Series Name="Cinsiyet" ChartType="Doughnut">
                            </asp:Series>
                        </Series>
                        <ChartAreas>
                            <asp:ChartArea Name="ChartArea1">
                            </asp:ChartArea>
                        </ChartAreas>
                    </asp:Chart>
                </td>
            </tr>
        </table>
    </form>



</asp:Content>
