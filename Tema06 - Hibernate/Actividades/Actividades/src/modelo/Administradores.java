package modelo;
// Generated 18-mar-2021 17:30:26 by Hibernate Tools 3.6.0



/**
 * Administradores generated by hbm2java
 */
public class Administradores  implements java.io.Serializable {


     private String usuario;
     private String nombre;
     private String apellidos;
     private String clave;
     private String email;

    public Administradores() {
    }

	
    public Administradores(String usuario) {
        this.usuario = usuario;
    }
    public Administradores(String usuario, String nombre, String apellidos, String clave, String email) {
       this.usuario = usuario;
       this.nombre = nombre;
       this.apellidos = apellidos;
       this.clave = clave;
       this.email = email;
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
    public String getClave() {
        return this.clave;
    }
    
    public void setClave(String clave) {
        this.clave = clave;
    }
    public String getEmail() {
        return this.email;
    }
    
    public void setEmail(String email) {
        this.email = email;
    }




}


