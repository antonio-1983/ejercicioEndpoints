﻿using Microsoft.AspNetCore.Mvc;
using Datos;
using EjercicioEndpoints.Modelo;

namespace EjercicioEndpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        public UsuarioController()
        {

        }

        [HttpGet("usuario/{id}")]
        public Usuario usuarioGet(int id)
        {
            Dato usuarioDato = new Dato();
            Usuario modelo = new Usuario();
            modelo = usuarioDato.ObtenerUsuario(id);
            return modelo; 
        }

        [HttpPost("usuario")]
        public Usuario usuarioPost(Usuario modelo)
        {
            Dato usuarioDato = new Dato();
            usuarioDato.InsertarUsuario(modelo.Nombre,modelo.Email,modelo.Contrasena);
            return modelo;
        }

        [HttpPatch("ActualizarUsuario/{id}")]
        public Usuario usuarioPut(int id)
        {
            Dato usuarioDato = new Dato();
            Usuario modelo = new Usuario();
            modelo = usuarioDato.ObtenerUsuario(id);
            usuarioDato.ActualizarUsuario(modelo.Id,modelo.Nombre, modelo.Email, modelo.Contrasena);
            return modelo;
        }

        [HttpDelete("EliminarUsuario/{id}")]
        public string usuarioDelete(int id)
        {
            Dato usuarioDato = new Dato();
            usuarioDato.EliminarUsuario(id);
            return "usuario eliminado";
        }
<<<<<<< HEAD


        [HttpPost("login")]//cambiar codigo
        public void usuarioLogin(Usuario modelo)
        {
            Dato usuarioDato = new Dato();
            usuarioDato.LoginUsuario(modelo.Id, modelo.Nombre, modelo.Email, modelo.Contrasena);
            
        }



=======
>>>>>>> 5715bbedbc4be8d63f9f404ab4818a07a8ffcf48
    }
}
