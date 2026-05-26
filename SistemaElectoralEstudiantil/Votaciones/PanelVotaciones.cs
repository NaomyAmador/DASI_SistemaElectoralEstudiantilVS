using Entidades;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SistemaElectoralEstudiantil.Votaciones
{
    public partial class frm_PanelVotaciones : Form
    {
        private LogicaNegocioVotacion VotacionBLL = new LogicaNegocioVotacion ();
        public frm_PanelVotaciones()
        {
            InitializeComponent();
        }

        private void PanelVotaciones_Load(object sender, EventArgs e)
        {
            btn_ActualizarDatos.Dock = DockStyle.None;
            btn_ActualizarDatos.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right); // Lo centra bonito dentro de su celda

            // 2. Definirle un tamaño fijo para que no se deforme con la tabla
            btn_ActualizarDatos.Size = btn_ActualizarDatos.Size;
            btn_ActualizarDatos.Font = btn_ActualizarDatos.Font;
            int margenDerecho = 20;
            int coordenadaX = this.ClientSize.Width - btn_ActualizarDatos.Width - margenDerecho;
            int coordenadaY = btn_ActualizarDatos.Location.Y;

            btn_ActualizarDatos.Location = new Point(coordenadaX, coordenadaY);
            btn_ActualizarDatos.BringToFront();

            //tm_Actualizar.Interval = 5000;
            //tm_Actualizar.Start();

            //Linea temporal para prueba
            // ─────────────────────────────────────────────────────────────────
            // 🛠️ AGREGA ESTO AQUÍ (Elige qué quieres probar cambiando estos valores)
           // ─────────────────────────────────────────────────────────────────
            //Sesion.UsuarioActual = new Usuarios { UsuarioID = 1, RolID = 1, YaVoto = true }; // true = Probar como Admin | false = Probar como Estudiante
            

           // tm_Actualizar.Interval = 5000;
            //tm_Actualizar.Start();

            // Verificar acceso según rol ANTES de cargar datos
            VerificarAccesoYMostrar();

            // ─────────────────────────────────────────────────────────────────
            
        }

        private void VerificarAccesoYMostrar()
         {
            // Si es administrador, ve todo sin restricción
            if (Sesion.EsAdmin)
            {
                MostrarContenidoCompleto();
                CargarDatos();
                return;
            }

            // Si es votante, verificamos si ya votó
            bool yaVoto = Sesion.UsuarioActual.YaVoto;

            if (yaVoto)
            {
                // Votante que ya votó: ve información limitada
                MostrarContenidoVotante();
                CargarDatos();
            }
            else
            {
                // Votante que NO ha votado: ve pantalla de aviso
                MostrarPantallaDeAviso();
            }
        }

        // ─────────────────────────────────────────────
        // Muestra TODO (solo admin)
        // ─────────────────────────────────────────────
        private void MostrarContenidoCompleto()
        {
            // Todo visible
            lbl_TotalPadron.Visible = true;
            lbl_VotosEmitidos.Visible = true;
            lbl_VotosNulos.Visible = true;
            lbl_PorEmitido.Visible = true;
            lbl_PorciNulos.Visible = true;
            chart_Pastel.Visible = true;
            chart_Barras.Visible = true;
            lbl_TiempoRes.Visible = true;
            btn_ActualizarDatos.Visible = true;
        }

        // ─────────────────────────────────────────────
        // Muestra solo lo permitido (votante que ya votó)
        // ─────────────────────────────────────────────
        private void MostrarContenidoVotante()
        {
            // El votante puede ver participación general y gráficas
            // pero NO el padrón total ni los nulos detallados
            lbl_TotalPadron.Visible = false; // no ve el padrón
            lbl_VotosEmitidos.Visible = true;  // sí ve cuántos votaron
            lbl_VotosNulos.Visible = false; // no ve nulos detallados
            lbl_PorEmitido.Visible = true;  // sí ve % participación
            lbl_PorciNulos.Visible = false; // no ve % nulos
            chart_Pastel.Visible = true;  // sí ve gráfica
            chart_Barras.Visible = true;  // sí ve barras
            lbl_TiempoRes.Visible = true;  // sí ve tiempo
            btn_ActualizarDatos.Visible = false; // no necesita actualizar
        }

        // ─────────────────────────────────────────────
        // Pantalla de aviso (votante que NO ha votado)
        // ─────────────────────────────────────────────
        private void MostrarPantallaDeAviso()
        {
            // Ocultar todo el contenido
            lbl_TotalPadron.Visible = false;
            lbl_VotosEmitidos.Visible = false;
            lbl_VotosNulos.Visible = false;
            lbl_PorEmitido.Visible = false;
            lbl_PorciNulos.Visible = false;
            chart_Pastel.Visible = false;
            chart_Barras.Visible = false;
            lbl_TiempoRes.Visible = false;
            btn_ActualizarDatos.Visible = false;

            // Detener el timer porque no hay nada que actualizar
            tm_Actualizar.Stop();

            // Mostrar mensaje de aviso en el centro del form
            // Creamos un label de aviso dinámicamente
            Label lblAviso = new Label();
            lblAviso.Text = "⚠ Debes emitir tu voto\npara poder ver\nlas estadísticas.";
            lblAviso.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            lblAviso.ForeColor = Color.FromArgb(180, 60, 60);
            lblAviso.TextAlign = ContentAlignment.MiddleCenter;
            lblAviso.AutoSize = false;
            lblAviso.Size = new Size(400, 200);
            lblAviso.Location = new Point(
                (this.ClientSize.Width - 400) / 2,
                (this.ClientSize.Height - 200) / 2
            );
            lblAviso.Name = "lblAvisoVoto";
            this.Controls.Add(lblAviso);
            lblAviso.BringToFront();

            // Botón para cerrar y volver a votar
            Button btnVolver = new Button();
            btnVolver.Text = "Ir a Votar";
            btnVolver.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            btnVolver.BackColor = Color.FromArgb(33, 150, 243);
            btnVolver.ForeColor = Color.White;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Size = new Size(150, 45);
            btnVolver.Location = new Point(
                (this.ClientSize.Width - 150) / 2,
                (this.ClientSize.Height - 200) / 2 + 210
            );
            btnVolver.Click += (s, e) =>
            {
                FrmVotaciones frm = new FrmVotaciones();
                frm.Show();
                this.Close();

            };
            this.Controls.Add(btnVolver);
            btnVolver.BringToFront();

        }

        // ─────────────────────────────────────────────
        // MÉTODO PRINCIPAL: carga y actualiza todo
        // ─────────────────────────────────────────────
        private void CargarDatos()
        {
            //// ─────────────────────────────────────────────────────────────────
            //// 🛠️ PEGA ESTE BLOQUE JUSTO ABAJO (Datos falsos para llenar las gráficas):
            //var s = new EstadisticasVotacion();
            //s.TotalPadron = 1200;
            //s.TotalVotaron = 850;
            //s.TotalNulos = 45;
            //s.PorcentajeParticipacion = 70.8;
            //s.PorcentajeNulos = 5.2;
            //s.TiempoRestante = new TimeSpan(2, 30, 15); // Quedan 2 horas y media

            //s.VotosPorPlancha = new Dictionary<string, int>();
            //s.VotosPorPlancha.Add("Plancha Trueno", 400);
            //s.VotosPorPlancha.Add("Fuerza Estudiantil", 280);
            //s.VotosPorPlancha.Add("Renovación Juvenil", 125);

            //s.PorcentajePorPlancha = new Dictionary<string, double>();
            //s.PorcentajePorPlancha.Add("Plancha Trueno", 47.1);
            //s.PorcentajePorPlancha.Add("Fuerza Estudiantil", 32.9);
            //s.PorcentajePorPlancha.Add("Renovación Juvenil", 14.7);

            // ─────────────────────────────────────────────────────────────────
            var resultado = VotacionBLL.ObtenerEstadisticas();

            if (!resultado.hayVotacion)
            {
                // No hay votación activa
                lbl_TotalPadron.Text = "—";
                lbl_VotosEmitidos.Text = "—";
                lbl_VotosNulos.Text = "—";
                lbl_PorEmitido.Text = "Sin votación activa";
                lbl_PorciNulos.Text = "";
                lbl_TiempoRes.Text = "00:00:00";
                return;
            }

            var s = resultado.stats;

            // ── Tarjetas de números ──
            lbl_TotalPadron.Text = s.TotalPadron.ToString("N0");
            lbl_VotosEmitidos.Text = s.TotalVotaron.ToString("N0");
            lbl_VotosNulos.Text = s.TotalNulos.ToString("N0");
            lbl_PorEmitido.Text = $"({s.PorcentajeParticipacion}%)";
            lbl_PorciNulos.Text = $"({s.PorcentajeNulos}%)";

            // ── Tiempo restante ──
            ActualizarTiempo(s.TiempoRestante);

            // ── Gráficas ──
            CargarGraficaPastel(s);
            CargarGraficaBarras(s);
        }

        // ─────────────────────────────────────────────
        // Gráfica de pastel
        // ─────────────────────────────────────────────
        private void CargarGraficaPastel(EstadisticasVotacion s)
        {
            chart_Pastel.Series.Clear();
            chart_Pastel.Titles.Clear();
            chart_Pastel.Legends.Clear();

            chart_Pastel.Titles.Add("Resultados por Plancha");

            Series serie = new Series("Votos");
            serie.ChartType = SeriesChartType.Pie;

            // Colores para cada plancha
            Color[] colores = new Color[]
            {
                Color.FromArgb(76, 175, 80),   // verde
                Color.FromArgb(33, 150, 243),  // azul
                Color.FromArgb(255, 152, 0),   // naranja
                Color.FromArgb(156, 39, 176),  // morado
                Color.FromArgb(244, 67, 54)    // rojo
            };

            int colorIndex = 0;
            foreach (var entry in s.VotosPorPlancha)
            {
                if (entry.Value > 0) // solo mostrar planchas con votos
                {
                    double porc = s.PorcentajePorPlancha.ContainsKey(entry.Key)
                        ? s.PorcentajePorPlancha[entry.Key] : 0;

                    DataPoint punto = new DataPoint();
                    punto.SetValueXY(entry.Key, entry.Value);
                    punto.Label = $"{porc}%";
                    punto.LegendText = $"{entry.Key} ({porc}%)";

                    if (colorIndex < colores.Length)
                        punto.Color = colores[colorIndex++];

                    serie.Points.Add(punto);
                }
            }

            // Agregar nulos si hay
            if (s.TotalNulos > 0)
            {
                DataPoint nulos = new DataPoint();
                nulos.SetValueXY("Nulos", s.TotalNulos);
                nulos.Label = $"{s.PorcentajeNulos}%";
                nulos.LegendText = $"Nulos ({s.PorcentajeNulos}%)";
                nulos.Color = Color.Gray;
                serie.Points.Add(nulos);
            }

            chart_Pastel.Series.Add(serie);

            // Leyenda
            Legend leyenda = new Legend();
            leyenda.Docking = Docking.Right;
            chart_Pastel.Legends.Add(leyenda);

            chart_Pastel.Invalidate();
        }

        // ─────────────────────────────────────────────
        // Gráfica de barras
        // ─────────────────────────────────────────────
        private void CargarGraficaBarras(EstadisticasVotacion s)
        {
            chart_Barras.Series.Clear();
            chart_Barras.Titles.Clear();

            chart_Barras.Titles.Add("Votos Válidos por Plancha");

            Series serie = new Series("Votos");
            serie.ChartType = SeriesChartType.Bar; // barras horizontales

            Color[] colores = new Color[]
            {
                Color.FromArgb(76, 175, 80),
                Color.FromArgb(33, 150, 243),
                Color.FromArgb(255, 152, 0),
                Color.FromArgb(156, 39, 176),
                Color.FromArgb(244, 67, 54)
            };

            int colorIndex = 0;
            foreach (var entry in s.VotosPorPlancha)
            {
                DataPoint punto = new DataPoint();
                punto.SetValueXY(entry.Key, entry.Value);
                punto.Label = entry.Value.ToString("N0");

                if (colorIndex < colores.Length)
                    punto.Color = colores[colorIndex++];

                serie.Points.Add(punto);
            }

            chart_Barras.Series.Add(serie);

            // Configurar ejes
            chart_Barras.ChartAreas[0].AxisX.LabelStyle.Font =
                new Font("Segoe UI", 8);
            chart_Barras.ChartAreas[0].AxisY.Minimum = 0;
            chart_Barras.ChartAreas[0].AxisY.LabelStyle.Format = "N0";

            chart_Barras.Invalidate();
        }

        // ─────────────────────────────────────────────
        // Actualizar cuenta regresiva
        // ─────────────────────────────────────────────
        private void ActualizarTiempo(TimeSpan tiempo)
        {
            if (tiempo <= TimeSpan.Zero)
            {
                lbl_TiempoRes.Text = "00:00:00";
                lbl_TiempoRes.ForeColor = Color.Red;
                tm_Actualizar.Stop();
                return;
            }

            // Mostrar días si quedan más de 24 horas
            if (tiempo.TotalHours >= 24)
                lbl_TiempoRes.Text = $"{(int)tiempo.TotalHours:D2}:{tiempo.Minutes:D2}:{tiempo.Seconds:D2}";
            else
                lbl_TiempoRes.Text = $"{tiempo.Hours:D2}:{tiempo.Minutes:D2}:{tiempo.Seconds:D2}";

            // Color según urgencia
            if (tiempo.TotalMinutes <= 30)
                lbl_TiempoRes.ForeColor = Color.Red;
            else if (tiempo.TotalHours <= 1)
                lbl_TiempoRes.ForeColor = Color.Orange;
            else
                lbl_TiempoRes.ForeColor = Color.FromArgb(33, 37, 41);
        }

        private void btn_ActualizarDatos_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void tm_Actualizar_Tick(object sender, EventArgs e)
        {
            if (!Sesion.EsAdmin && !Sesion.UsuarioActual.YaVoto)
            {
                LogicaNegocioVotacion logicaVotacion = new LogicaNegocioVotacion();
                Usuarios usuarioActualizado =
                    logicaVotacion.ObtenerUsuarioPorID(Sesion.UsuarioActual.UsuarioID);

                if (usuarioActualizado != null && usuarioActualizado.YaVoto)
                {
                    Sesion.UsuarioActual.YaVoto = true;
                    var lblAviso = this.Controls["lblAvisoVoto"];
                    if (lblAviso != null) this.Controls.Remove(lblAviso);
                    MostrarContenidoVotante();
                    CargarDatos();
                    tm_Actualizar.Start();
                }
                return;
            }
            CargarDatos();
        }
        private void frmPanelVotaciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            tm_Actualizar.Stop();
        }

        private void btn_VolverMenu_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
    
}
