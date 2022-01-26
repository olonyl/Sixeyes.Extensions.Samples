Imports NUnit.Framework
Imports Sixeyed.Extensions.Advanced.Demo3

Namespace Sixeyed.Extension.Advanced.VBUnitTests

    Public Class Tests

        <SetUp>
        Public Sub Setup()
        End Sub

        <Test>
        Public Sub ToXmlDateTime()
            Dim dateTime As New DateTime(2013, 10, 24)
            Assert.Pass("2013-10-24T00:00:00Z", dateTime.ToXmlDateTime())
        End Sub

    End Class

End Namespace