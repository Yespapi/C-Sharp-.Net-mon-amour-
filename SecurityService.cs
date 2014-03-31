using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.SessionState;


public SecurityService
{
	public SecurityService (IPersonneService _personne, HttpSessionState session =null) 
	
	{ _personnes= personnes;
            _session = session ?? HttpContext.Current.Session;
    }
	
	public bool Authenticate(string prenom, string password )
	{
	
		var personne = _personnes.GetBy(prenom);
		if(personne == null)
		{
			return false;
		}
		return Crypto.VerifyHasPassword(personne.Password, password);
	}
	
	 
}
