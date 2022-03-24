package modelo;
// Generated 08-feb-2019 17:31:55 by Hibernate Tools 3.6.0


import java.util.HashSet;
import java.util.Set;

/**
 * Usuarios generated by hbm2java
 */
public class Usuarios  implements java.io.Serializable {


     private String usuario;
     private String nombre;
     private String apellidos;
     private String calle;
     private Integer numero;
     private String cp;
     private String telefono;
     private String email;
     private String provincia;
     private String clave;
     private Set noticiases = new HashSet(0);

    public Usuarios() {
    }

	
    public Usuarios(String usuario) {
        this.usuario = usuario;
    }
    public Usuarios(String usuario, String nombre, String apellidos, String calle, Integer numero, String cp, String telefono, String email, String provincia, String clave, Set noticiases) {
       this.usuario = usuario;
       this.nombre = nombre;
       this.apellidos = apellidos;
       this.calle = calle;
       this.numero = numero;
       this.cp = cp;
       this.telefono = telefono;
       this.email = email;
       this.provincia = provincia;
       this.clave = clave;
       this.noticiases = noticiases;
    }
    
    public Usuarios(String usuario, String nombre, String apellidos, String calle, Integer numero,
    String cp, String telefono, String email, String provincia, String clave) {
       this.usuario = usuario;
       this.nombre = nombre;
       this.apellidos = apellidos;
       this.calle = calle;
       this.numero = numero;
       this.cp = cp;
       this.telefono = telefono;
       this.email = email;
       this.provincia = provincia;
       this.clave = clave;
    }

   
    public String getUsuario() {
        return this.usuario;
    }
    
    public void setUsuario(String usuario) {
        this.usuario = usuario;
    }
    public String getNombre() {
        return this.nombre;
    }
    
    public void setNombre(String nombre) {
        this.nombre = nombre;
    }
    public String getApellidos() {
        return this.apellidos;
    }
    
    public void setApellidos(String apellidos) {
        this.apellidos = apellidos;
    }
    public String getCalle() {
        return this.calle;
    }
    
    public void setCalle(String calle) {
        this.calle = calle;
    }
    public Integer getNumero() {
        return this.numero;
    }
    
    public void setNumero(Integer numero) {
        this.numero = numero;
    }
    public String getCp() {
        return this.cp;
    }
    
    public void setCp(String cp) {
        this.cp = cp;
    }
    public String getTelefono() {
        return this.telefono;
    }
    
    public void setTelefono(String telefono) {
        this.telefono = telefono;
    }
    public String getEmail() {
        return this.email;
    }
    
    public void setEmail(String email) {
        this.email = email;
    }
    public String getProvincia() {
        return this.provincia;
    }
    
    public void setProvincia(String provincia) {
        this.provincia = provincia;
    }
    public String getClave() {
        return this.clave;
    }
    
    public void setClave(String clave) {
        this.clave = clave;
    }
    public Set getNoticiases() {
        return this.noticiases;
    }
    
    public void setNoticiases(Set noticiases) {
        this.noticiases = noticiases;
    }




}

