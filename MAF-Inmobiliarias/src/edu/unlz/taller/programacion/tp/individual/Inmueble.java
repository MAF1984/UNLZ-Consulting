package edu.unlz.taller.programacion.tp.individual;

public class Inmueble implements Imprimible {

	// ATRIBUTOS
	private String domicilio;
	private Integer superficie;
	private Double precio;
	private Boolean reservado;
	private Boolean vendido;
	private Cliente propietario;

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
		if (propietario == null) {
			if (other.propietario != null)
				return false;
		} else if (!propietario.equals(other.propietario))
			return false;
		if (reservado == null) {
			if (other.reservado != null)
				return false;
		} else if (!reservado.equals(other.reservado))
			return false;
		if (superficie == null) {
			if (other.superficie != null)
				return false;
		} else if (!superficie.equals(other.superficie))
			return false;
		if (vendido == null) {
			if (other.vendido != null)
				return false;
		} else if (!vendido.equals(other.vendido))
			return false;
		return true;
	}

	@Override
	public int hashCode() {
		final int prime = 31;
		int result = 1;
		result = prime * result + ((domicilio == null) ? 0 : domicilio.hashCode());
		result = prime * result + ((precio == null) ? 0 : precio.hashCode());
		result = prime * result + ((propietario == null) ? 0 : propietario.hashCode());
		result = prime * result + ((reservado == null) ? 0 : reservado.hashCode());
		result = prime * result + ((superficie == null) ? 0 : superficie.hashCode());
		result = prime * result + ((vendido == null) ? 0 : vendido.hashCode());
		return result;
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
