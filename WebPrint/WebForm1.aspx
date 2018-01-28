<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebPrint.WebForm1" %>
<%@ Register Assembly="FastReport.Web" Namespace="FastReport.Web" TagPrefix="cc1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <cc1:webreport id="WebReport1" runat="server" backcolor="White" font-bold="False"
                width="800px" height="1000px"
                onstartreport="WebReport1_StartReport" padding="5, 5, 5, 5" toolbarcolor="Lavender"
                printinpdf="True"
                pdfembeddingfonts="True"
                layers="False" zoom="1"
                toolbarstyle="Large"
                toolbarbackgroundstyle="Light"
                toolbariconsstyle="Blue" PdfProducer="" ReportResourceString="77u/PB0TGFuZ3VhZ2U9IkNTaGFycCIgUmVwb3J0SW5mby5DcmVhdGVkPSIwMS8yOC8yMDE4IDE5OjU3OjE4IiBSZXBvcnRJbmZvLk1vZGlmaWVkPSIwMS8yOC8yMDE4IDE5OjU3OjUwIiBSZXBvcnRJbmZvLkNyZWF0b3JWZXJzaW9uPSIyMDE0LjQuOC4wIj4NCiAgPERpY3Rpb25hcnkvPg0KICA8UmVwb3J0UGFnZSBOYW1lPSJQYWdlMSI+DQogICAgPFJlcG9ydFRpdGxlQmFuZCBOYW1lPSJSZXBvcnRUaXRsZTEiIFdpZHRoPSI3MTguMiIgSGVpZ2h0PSI0Ny4yNSI+DQogICAgICA8VGV4dE9iamVjdCBOYW1lPSJUZXh0MSIgTGVmdD0iMTcwLjEiIFRvcD0iMjguMzUiIFdpZHRoPSI5NC41IiBIZWlnaHQ9IjE4LjkiIFRleHQ9Iua1i+ivlSIgRm9udD0i5a6L5L2TLCA5cHQiLz4NCiAgICA8L1JlcG9ydFRpdGxlQmFuZD4NCiAgICA8UGFnZUhlYWRlckJhbmQgTmFtZT0iUGFnZUhlYWRlcjEiIFRvcD0iNTAuNTYiIFdpZHRoPSI3MTguMiIgSGVpZ2h0PSIyOC4zNSIvPg0KICAgIDxEYXRhQmFuZCBOYW1lPSJEYXRhMSIgVG9wPSI4Mi4yMyIgV2lkdGg9IjcxOC4yIiBIZWlnaHQ9Ijc1LjYiLz4NCiAgICA8UGFnZUZvb3RlckJhbmQgTmFtZT0iUGFnZUZvb3RlcjEiIFRvcD0iMTYxLjE0IiBXaWR0aD0iNzE4LjIiIEhlaWdodD0iMTguOSIvPg0KICA8L1JlcG9ydFBhZ2U+DQo8L1JlcG9ydD4NCg==" />
    </div>
    </form>
</body>
</html>
