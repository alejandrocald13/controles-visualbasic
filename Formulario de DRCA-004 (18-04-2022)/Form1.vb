Public Class Form1
    Public var1 As Integer
    Sub asignarmunicipios(departamento, numero)
        Dim municipios() As String
        municipios = {}
        Select Case departamento
            Case "Alta Verapaz"
                municipios = {"Coban", "Santa Cruz Verapaz", "San Cristobal Verapaz", "Tactic", "Tamahu", "San Miguel Tucuru", "Panzos", "Senahu", "San Pedro Carcha", "San Juan Chamelco", "Lanquin", "Santa Maria Cahabon", "Chisec", "Chahal", "Fray Bartolome De Las Casas", "La Tinta", "Raxruhá"}
            Case "Baja Verapaz"
                municipios = {"Salama", "San Miguel Chicaj", "Rabinal", "Cubulco", "Granados", "Santa Cruz El Chol", "San Jeronimo", "Purulha"}
            Case "Chimaltenango"
                municipios = {"Chimaltenango", "San Jose Poaquil", "San Martin Jilotepeque", "San Juan Comalapa", "Santa Apolonia", "Tecpan Guatemala", "Patzun", "San Miguel Pochuta", "Patzicia", "Santa Cruz Balanya", "Acatenango", "San Pedro Yepocapa", "San Andres Itzapa", "Parramos", "Zaragoza", "El Tejar"}
            Case "Chiquimula"
                municipios = {"Chiquimula", "San Jose La Arada", "San Juan La Ermita", "Jocotan", "Camotan", "Olopa", "Esquipulas", "Concepcion Las Minas", "Quezaltepeque", "San Jacinto", "Ipala"}
            Case "Guatemala"
                municipios = {"Guatemala", "Santa Catarina Pinula", "San Jose Pinula", "San Jose Del Golfo", "Palencia", "Chinautla", "San Pedro Ayampuc", "Mixco", "San Pedro Sacatepequez", "San Juan Sacatepequez", "San Raymundo", "Chuarrancho", "Fraijanes", "Amatitlan", "Villa Nueva", "Villa Canales", "San Miguel Petapa"}
            Case "El Progreso"
                municipios = {"Guastatoya", "Morazan", "San Agustin Acasaguastlan", "San Cristobal Acasaguastlan", "El Jicaro", "Sansare", "Sanarate", "San Antonio La Paz"}
            Case "Escuintla"
                municipios = {"Escuintla", "Santa Lucia Cotzumalguapa", "La Democracia", "Siquinala", "Masagua", "Tiquisate", "La Gomera", "Guanagazapa", "San Jose", "Iztapa", "Palin", "San Vicente Pacaya"}
            Case "Huehuetenango"
                municipios = {"Huehuetenango", "Chiantla", "Malacatancito", "Cuilco", "Nenton", "San Pedro Necta", "Jacaltenango", "San Pedro Soloma", "San Ildefonso Ixtahuacan", "Santa Barbara", "La Libertad", "La Democracia", "San Miguel Acatan", "San Rafael La Independencia", "Todos Santos Cuchumatan", "San Juan Atitan", "Santa Eulalia", "San Mateo Ixtatan", "Colotenango", "San Sebastian Huehuetenango", "Tectitan", "Concepcion Huista", "San Juan Ixcoy", "San Antonio Huista", "San Sebastian Coatan", "Santa Cruz Barillas", "Aguacatan", "San Rafael Petzal", "San Gaspar Ixchil", "Santiago Chimaltenango", "Santa Ana Huista", "Unión Cantinil"}
            Case "Izabal"
                municipios = {"Puerto Barrios", "Livingston", "El Estor", "Morales", "Los Amates"}
            Case "Jalapa"
                municipios = {"Jalapa", "San Pedro Pinula", "San Luis Jilotepeque", "San Manuel Chaparron", "San Carlos Alzatate", "Monjas", "Mataquescuintla"}
            Case "Jutiapa"
                municipios = {"Jutiapa", "El Progreso", "Santa Catarina Mita", "Agua Blanca", "Asuncion Mita", "Yupiltepeque", "Atescatempa", "Jerez", "El Adelanto", "Zapotitlan", "Comapa", "Jalpatagua", "Conguaco", "Moyuta", "Pasaco", "San Jose Acatempa", "Quesada"}
            Case "Petén"
                municipios = {"Flores", "San Jose", "San Benito", "San Andres", "La Libertad", "San Francisco", "Santa Ana", "Dolores", "San Luis", "Sayaxche", "Melchor De Mencos", "Poptun"}
            Case "Quetzaltenango"
                municipios = {"Quetzaltenango", "Salcaja", "Olintepeque", "San Carlos Sija", "Sibilia", "Cabrican", "Cajola", "San Miguel Siguila", "San Juan Ostuncalco", "San Mateo", "Concepcion Chiquirichapa", "San Martin Sacatepequez", "Almolonga", "Cantel", "Huitan", "Zunil", "Colomba Costa Cuca", "San Francisco La Union", "El Palmar", "Coatepeque", "Genova Costa Cuca", "Flores Costa Cuca", "La Esperanza", "Palestina De Los Altos"}
            Case "Quiché"
                municipios = {"Santa Cruz Del Quiche", "Chiche", "Chinique", "Zacualpa", "Chajul", "Sto Tomas Chichicastenango", "Patzite", "San Antonio Ilotenango", "San Pedro Jocopilas", "Cunen", "San Juan Cotzal", "Joyabaj", "Nebaj", "San Andres Sajcabaja", "San Miguel Uspantan", "Sacapulas", "San Bartolome Jocotenango", "Canilla", "Chicaman", "Ixcan", "Pachalun", "Playa Grande"}
            Case "Retalhuleu"
                municipios = {"Retalhuleu", "San Sebastian", "Santa Cruz Mulua", "San Martin Zapotitlan", "San Felipe", "San Andres Villa Seca", "Champerico", "Nuevo San Carlos", "El Asintal"}
            Case "Sacatepequez"
                municipios = {"Antigua", "Jocotenango", "Pastores", "Sumpango", "Santo Domingo Xenacoj", "Santiago Sacatepequez", "San Bartolome Milpas Altas", "San Lucas Sacatepequez", "Santa Lucia Milpas Altas", "Magdalena Milpas Altas", "Santa Maria De Jesus", "Ciudad Vieja", "San Miguel Duenas", "Alotenango", "San Antonio Aguas Calientes", "Santa Catarina Barahona"}
            Case "San Marcos"
                municipios = {"San Marcos", "San Pedro Sacatepequez", "San Antonio Sacatepequez", "Comitancillo", "San Miguel Ixtahuacan", "Concepcion Tutuapa", "Tacana", "Sibinal", "Tajumulco", "Tejutla", "San Rafael Pie De La Cuesta", "Nuevo Progreso", "El Tumbador", "San Jose El Rodeo", "Malacatan", "Catarina", "Ayutla (Tecun Uman)", "Ocos", "San Pablo", "El Quetzal", "La Reforma", "Pajapita", "Ixchiguan", "San Jose Ojetenan", "San Cristobal Cucho", "Sipacapa", "Esquipulas Palo Gordo", "Rio Blanco", "San Lorenzo"}
            Case "Santa Rosa"
                municipios = {"Cuilapa", "Barberena", "Santa Rosa De Lima", "Casillas", "San Rafael Las Flores", "Oratorio", "San Juan Tecuaco", "Chiquimulilla", "Taxisco", "Santa Maria Ixhuatan", "Guazacapan", "Santa Cruz Naranjo", "Municipio Nuevo Viñas", "Nueva Santa Rosa"}
            Case "Sololá"
                municipios = {"Solola", "San Jose Chacaya", "Santa Maria Visitacion", "Santa Lucia Utatlan", "Nahuala", "Santa Catarina Ixtahuacan", "Santa Clara La Laguna", "Concepcion", "San Andres Semetabaj", "Panajachel", "Santa Catarina Palopo", "San Antonio Palopo", "San Lucas Toliman", "Santa Cruz La Laguna", "San Pablo La Laguna", "San Marcos La Laguna", "San Juan La Laguna", "San Pedro La Laguna", "Santiago Atitlan"}
            Case "Suchitepequez"
                municipios = {"Mazatenango", "Cuyotenango", "San Francisco Zapotitlan", "San Bernardino", "San Jose El Idolo", "Santo Domingo Suchitepequez", "San Lorenzo", "Samayac", "San Pablo Jocopilas", "San Antonio Suchitepequez", "San Miguel Panam", "San Gabriel", "Chicacao", "Patulul", "Santa Barbara", "San Juan Bautista", "Santo Tomas La Union", "Zunilito", "Municipio Nuevo", "Rio Bravo"}
            Case "Totonicapán"
                municipios = {"Totonicapan", "San Cristobal Totonicapan", "San Francisco El Alto", "San Andres Xecul", "Momostenango", "Santa Maria Chiquimula", "Santa Lucia La Reforma", "San Bartolo Aguas Calientes"}
            Case "Zacapa"
                municipios = {"Zacapa", "Estanzuela", "Rio Hondo", "Gualan", "Teculutan", "Usumatlan", "Cabanas", "San Diego", "La Union", "Huite"}
        End Select
        If numero = 1 Then
            cbmunicipios.Items.Clear()
            cbmunicipios.Items.AddRange(municipios)
        End If
        If numero = 2 Then
            cbmunicipio.Items.Clear()
            cbmunicipio.Items.AddRange(municipios)
        End If
    End Sub
    Private Sub cbdepartamentos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbdepartamentos.SelectedIndexChanged
        Call asignarmunicipios(cbdepartamentos.SelectedItem, 1)
    End Sub
    Private Sub cbdepartamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbdepartamento.SelectedIndexChanged
        Call asignarmunicipios(cbdepartamento.SelectedItem, 2)
    End Sub

    Private Sub cbTY_CheckedChanged(sender As Object, e As EventArgs) Handles cbTY.CheckedChanged
        If cbTY.Checked = True Then
            cbEnero.Enabled = False
            cbEnero.Checked = False
            cbFebrero.Enabled = False
            cbFebrero.Checked = False
            cbMarzo.Enabled = False
            cbMarzo.Checked = False
            cbAbril.Enabled = False
            cbAbril.Checked = False
            cbMay.Enabled = False
            cbMay.Checked = False
            cbJune.Enabled = False
            cbJune.Checked = False
            cbJuly.Enabled = False
            cbJuly.Checked = False
            cbAugust.Enabled = False
            cbAugust.Checked = False
            cbSep.Enabled = False
            cbSep.Checked = False
            cbOcto.Enabled = False
            cbOcto.Checked = False
            cbNovem.Enabled = False
            cbNovem.Checked = False
            cbDecem.Enabled = False
            cbDecem.Checked = False
        End If
        If cbTY.Checked = False Then
            cbEnero.Enabled = True
            cbFebrero.Enabled = True
            cbMarzo.Enabled = True
            cbAbril.Enabled = True
            cbMay.Enabled = True
            cbJune.Enabled = True
            cbJuly.Enabled = True
            cbAugust.Enabled = True
            cbSep.Enabled = True
            cbOcto.Enabled = True
            cbNovem.Enabled = True
            cbDecem.Enabled = True
        End If
    End Sub

    Private Sub cbDiario_CheckedChanged(sender As Object, e As EventArgs) Handles cbDiario.CheckedChanged
        If cbDiario.Checked = True Then
            cbLunes.Checked = False
            cbLunes.Enabled = False
            cbMartes.Checked = False
            cbMartes.Enabled = False
            cbMiercoles.Checked = False
            cbMiercoles.Enabled = False
            cbJueves.Checked = False
            cbJueves.Enabled = False
            cbViernes.Checked = False
            cbViernes.Enabled = False
            cbSabado.Checked = False
            cbSabado.Enabled = False
            cbDomingo.Checked = False
            cbDomingo.Enabled = False
        End If
        If cbDiario.Checked = False Then
            cbLunes.Enabled = True
            cbMartes.Enabled = True
            cbMiercoles.Enabled = True
            cbJueves.Enabled = True
            cbViernes.Enabled = True
            cbSabado.Enabled = True
            cbDomingo.Enabled = True
        End If
    End Sub
    Private Sub bPrint_Click(sender As Object, e As EventArgs) Handles bPrint.Click
        FormReporte.Show()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim var1 As Integer

    End Sub
End Class

