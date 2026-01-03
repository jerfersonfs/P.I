using Microsoft.ReportingServices.Diagnostics.Internal;
using Projeto_Integrador___pt2.Formulários;
using Projeto_Integrador___pt2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_Integrador___pt2;

namespace Projeto_Integrador___pt2
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
//        [STAThread]
        /*static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run();
        }*/
        [STAThread]
        static void Main()
        {
            bool modoTesteConexao = true; // ← ALTERE AQUI

            if (modoTesteConexao)
            {
                TestarConexaoSupabase();
                return; // impede o resto do sistema
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
        static void TestarConexaoSupabase()
        {
            try
            {
                using (var conn = new Conection())
                {
                    conn.Open();
                    MessageBox.Show(
                        "Conexão com Supabase OK!",
                        "Teste de Conexão",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Erro ao conectar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
    }
