using Sistema.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.Modelo
{
    public class Controle
    {
        public bool tem;
        public String mensagem = ""; 
        public bool acessar(String username, String senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.verificarLogin(username, senha);
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }

        public String cadastrar(String email, String senha, String confSenha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.cadastrar(email, senha, confSenha);
            if (loginDao.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }

        public String cadastrarPalavras(String palavras, String traducao)
        {
            LoginDaoComandos loginDao2 = new LoginDaoComandos();
            this.mensagem = loginDao2.cadastrarPalavras(palavras, traducao);
            if(loginDao2.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
