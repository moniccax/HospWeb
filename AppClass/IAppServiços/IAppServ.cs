﻿using DomainClass.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppClass.IAppServiços
{
	public interface IAppServ
	{

		Telefone TipoTelefone(double telefone, int codChale);
	}
}


//telefone seria uma nova entidade do dominio?