<?xml version="1.0" encoding="iso-8859-1"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
    <html>
      <body>
        <h2>Students</h2>
        <table border="1">
          <tr bgcolor="#9acd32">
            <th style="text-align:left">Name</th>
            <th style="text-align:left">Sex</th>
            <th style="text-align:left">Birth date</th>
            <th style="text-align:left">Phone</th>
            <th style="text-align:left">E-mail</th>
            <th style="text-align:left">Course</th>
            <th style="text-align:left">Specialty</th>
            <th style="text-align:left">Faculty number</th>
            <th style="text-align:left">Taken exams</th>
          </tr>
          <xsl:for-each select="students/student">
            <tr>
              <td>
                <xsl:value-of select="name"/>
              </td>
              <td>
                <xsl:value-of select="sex"/>
              </td>
              <td>
                <xsl:value-of select="birth-date"/>
              </td>
              <td>
                <xsl:value-of select="phone"/>
              </td>
              <td>
                <xsl:value-of select="email"/>
              </td>
              <td>
                <xsl:value-of select="course"/>
              </td>
              <td>
                <xsl:value-of select="specialty"/>
              </td>
              <td>
                <xsl:value-of select="faculty-number"/>
              </td>
              <td>
                  <table border="1">
                    <tr bgcolor="#9acd32">
                      <th style="text-align:left">Name</th>
                      <th style="text-align:left">Tutor</th>
                      <th style="text-align:left">Score</th>
                    </tr>
                    <xsl:for-each select="taken-exams/exam">
                    <tr>
                      <td>
                        <xsl:value-of select="name"/>
                      </td>
                      <td>
                        <xsl:value-of select="tutor"/>
                      </td>
                      <td>
                        <xsl:value-of select="score"/>
                      </td>
                    </tr>
                    </xsl:for-each>
                  </table>
              </td>
            </tr>
          </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>