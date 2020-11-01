package edu.unlz.taller.programacion.tp.individual;

/**
 * @author maf
 *
 */

//ATRIBUTOS
public class Cliente implements Imprimible {
	private String nombre;
	private String telefono;
	private String correo;

	// CONSTRUCTORES
	/**
	 * @param nombre
	 * @param telefono
	 * @param correo
	 */

	public Cliente(String nombre, String telefono, String correo) {
		this.nombre = nombre;
		this.telefono = telefono;
		this.correo = correo;
	}

	// METODOS
	// Comprobacion booleana para constatar ingreso de datos de propietarios validos

	public Boolean datoValido() {
		if (this.correo != null && nombre != null && telefono != null)
			;
		return true;
	}

	// Salida por consola de los datos del propietario
	public void imprimirDatos() {
		System.out.println("Datos Del Propietario");
		System.out.println("Nombre: " + this.getNombre());
		System.out.println("Telefono: " + this.getTelefono());
		System.out.println("Correo: " + this.getCorreo());
		System.out.println("");
		System.out.println("**************************************");

	}

	@Override
	public int hashCode() {
		final int prime = 31;
		int result = 1;
		result = prime * result + ((correo == null) ? 0 : correo.hashCode());
		result = prime * result + ((nombre == null) ? 0 : nombre.hashCode());
		result = prime * result + ((telefono == null) ? 0 : telefono.hashCode());
		return result;
	}

	@Override
	public boolean equals(Object obj) {
		if (this == obj)
			return true;
		if (obj == null)
			return false;
		if (getClass() != obj.getClass())
			return false;
		Cliente other = (Cliente) obj;
		if (correo == null) {
			if (other.correo != null)
				return false;
		} else if (!correo.equals(other.correo))
			return false;
		if (nombre == null) {
			if (other.nombre != null)
				return false;
		} else if (!nombre.equals(other.nombre))
			return false;
		if (telefono == null) {
			if (other.telefono != null)
				return false;
		} else if (!telefono.equals(other.telefono))
			return false;
		return true;
	}

//GETTERS y SETTERS
	//Getter y setter nombre del cliente
	public String getNombre() {
		return nombre;
	}
	public void setNombre(String nombre) {
		this.nombre = nombre;
	}

	//Getter y setter telefono del cliente
	public String getTelefono() {
		return telefono;
	}
	public void setTelefono(String telefono) {
		this.telefono = telefono;
	}

	//Getter y setter correo electronico del cliente
	public String getCorreo() {
		return correo;
	}
	public void setCorreo(String correo) {
		this.correo = correo;
	}

}
