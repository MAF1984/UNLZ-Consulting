package edu.unlz.taller.programacion.tp.individual;

public class Inmueble implements Imprimible, Comparable<Inmueble> {

	// ATRIBUTOS
	protected String domicilio;
	protected Integer superficie;
	protected Double precio;
	protected Boolean reservado;
	protected Boolean vendido;
	protected Cliente propietario;

	// CONSTRUCTOR
	/**
	 * @param domicilio
	 * @param superficie
	 * @param precio
	 * @param reservado
	 * @param vendido
	 * @param propietario
	 */

	public Inmueble(String domicilio, Integer superficie, Double precio, Boolean reservado, Boolean vendido,
			Cliente propietario) {
		this.domicilio = domicilio;
		this.superficie = superficie;
		this.precio = precio;
		this.reservado = reservado;
		this.vendido = vendido;
		this.propietario = propietario;

	}

//METODOS
	//Metodo para salida por consola de datos propiedades, estados de reserva, ventas y datos de los propietarios
	public void imprimirDatos() {
		System.out.println("Domicilio: " + this.getDomicilio());
		System.out.println("Superficie: " + this.getSuperficie() + " M2.");
		System.out.println("Precio: " + this.getPrecio());
		System.out.println("Reservado: " + this.getReservado());
		System.out.println("Vendido: " + this.getVendido());
		System.out.println("");
		this.getPropietario().imprimirDatos();

	}

	/**
	* Metodo par calcular el Beneficio Obtenido de los inmuebles que no estan reservados 
	* ni fueron vendidos 
	*/
	public Double beneficioEsperado(Double COMISION) {
		return this.precio * COMISION;
	}

	
	//Metodo par calcular el Beneficio Obtenido de inmuebles vendidos/reservados 
	public Double beneficioObtenido(Double COMISION) {
			return this.precio * COMISION;
		}


	// metodo para comparar precios
	@Override
		public int compareTo(Inmueble o) {
		return this.precio.compareTo(o.getPrecio());
		}
		
		@Override
		public int hashCode() {
			final int prime = 31;
			int result = 1;
			result = prime * result + ((domicilio == null) ? 0 : domicilio.hashCode());
			result = prime * result + ((precio == null) ? 0 : precio.hashCode());
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
			Inmueble other = (Inmueble) obj;
			if (domicilio == null) {
				if (other.domicilio != null)
					return false;
			} else if (!domicilio.equals(other.domicilio))
				return false;
			if (precio == null) {
				if (other.precio != null)
					return false;
			} else if (!precio.equals(other.precio))
				return false;
			return true;
		}

//GETTERS y SETTERS
	//Getter y setter del domicilio de las propiedades de la inmobiliaria
	public String getDomicilio() {
		return domicilio;
	}
	public void setDomicilio(String domicilio) {
		this.domicilio = domicilio;
	}

	//Getter y setter de superficie en M2 de las propiedades de la inmobiliaria
	public Integer getSuperficie() {
		return superficie;
	}
	public void SetSuperficie(Integer superficie) {
		this.superficie = superficie;
	}

	//Getter y setter de precios en USD de las propiedades de la inmobiliaria
	public Double getPrecio() {
		return precio;
	}
	public void setPrecio(Double precio) {
		this.precio = precio;
	}

	//Getter y setter booleano del estado de reserva
	public Boolean getReservado() {
		return reservado;
	}
	public void setReservado(Boolean reservado) {
		this.reservado = reservado;
	}

	//Getter y setter booleano del estado de venta
	public Boolean getVendido() {
		return vendido;
	}
	public void setVendido(Boolean vendido) {
		this.vendido = vendido;
	}

	//Getter y setter de los propietarios de los inmuebles
	public Cliente getPropietario() {
		return propietario;
	}
	public void setPropietario(Cliente propietario) {
		this.propietario = propietario;
	}

}
