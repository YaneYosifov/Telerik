<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"
    xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:template match="/">
        <html>
            <head>
                <style>
                    table, th, td {
                        border: 1px solid black;
                        border-collapse: collapse;
                        padding: 2px;
                        vertical-align: top;
                    }
                    
                    th {
                        background-color: lightgreen;
                    }
                    
                    ul {
                        margin: 0;
                        padding-left: 20px;
                    }
                </style>
            </head>
            <body>
                <h2>Students</h2>
                <table>
                    <thead>
                        <th>Name</th>
                        <th>Sex</th>
                        <th>Birth date</th>
                        <th>Phone</th>
                        <th>Email</th>
                        <th>Speciality</th>
                        <th>Faculty number</th>
                        <th>Exams</th>
                    </thead>
                    <tbody>
                        <xsl:for-each select="students/student">
                            <tr>
                                <td>
                                    <xsl:value-of select="name"/>
                                </td>
                                <td>
                                    <xsl:value-of select="sex"/>
                                </td>
                                <td>
                                    <xsl:value-of select="birtdDate"/>
                                </td>
                                <td>
                                    <xsl:value-of select="phone"/>
                                </td>
                                <td>
                                    <xsl:value-of select="email"/>
                                </td>
                                <td>
                                    <xsl:value-of select="speciality"/>
                                </td>
                                <td>
                                    <xsl:value-of select="facultyNumber"/>
                                </td>
                                <td>
                                    <ul>
                                        <xsl:for-each select="exams/exam">
                                            <li>
                                                <strong>
                                                    <xsl:value-of select="name"/>
                                                </strong> / Teacher: 
                                                <xsl:value-of select="tutor"/> / Score: 
                                                <xsl:value-of select="score"/>
                                            </li>
                                        </xsl:for-each>
                                    </ul>
                                </td>
                            </tr>
                        </xsl:for-each>
                    </tbody>
                </table>
            </body>
        </html>
    </xsl:template>
</xsl:stylesheet>