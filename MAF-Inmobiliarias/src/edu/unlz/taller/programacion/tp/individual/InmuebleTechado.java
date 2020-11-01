package edu.unlz.taller.programacion.tp.individual;

/**
 * @author maf
 *
 */

//ATRIBUTOS
public class InmuebleTechado extends Inmueble {
	private Integer cantidadDeAmbientes;
	private Boolean tieneCochera;
	private Boolean tienePiscina;

//CONSTRUCTOR
	/**
	 * @param domicilio
	 * @param superficie
	 * @param precio
	 * @param reservado
	 * @param vendido
	 * @param propietario
	 * @param cantidadDeAmbientes
	 * @param tieneCochera
	 * @param tienePiscina
	 */

	public InmuebleTechado(String domicilio, Integer superficie, Double precio, Boolean reservado, Boolean vendido,
			Cliente propietario, Integer cantidadDeAmbientes, Boolean tieneCochera, Boolean tienePiscina) {
		super(domicilio, superficie, precio, reservado, vendido, propietario);
		this.cantidadDeAmbientes = cantidadDeAmbientes;
		this.tieneCochera = tieneCochera;
		this.tienePiscina = tienePiscina;
	}

//METODOS

	@Override
	public void imprimirDatos() {
		System.out.println("Domicilio: " + this.getDomicilio());
		System.out.println("Superficie: " + this.getSuperficie() + " M2.");
		System.out.println("Precio: " + this.getPrecio());
		System.out.println("Reservado: " + this.getReservado());
		System.out.println("Vendido: " + this.getVendido());
		System.out.println("");
		System.out.println("Cantidad de ambientes: " + this.getCantidadDeAmbientes());
		System.out.println("Cuenta con Cochera: " + this.getTieneCochera());
		System.out.println("Cuenta con Piscina: " + this.getTienePiscina());
		System.out.println("");
		this.getPropietario().imprimirDatos();
	}

//GETTERS y SETTERS
	//Getter y setter cantidad de ambientes de propiedades techadas
	public Integer getCantidadDeAmbientes() {
		return cantidadDeAmbientes;
	}
	public void setcantidadDeAmbientes(Integer cantidadDeAmbientes) {
		this.cantidadDeAmbientes = cantidadDeAmbientes;
	}

	//Getter y setter booleano para definir presencia/ausencia de Cochera
	public Boolean getTieneCochera() {
		return tieneCochera;
	}
	public void setTieneCochera(Boolean tieneCochera) {
		this.tieneCochera = tieneCochera;
	}

	//Getter y setter booleano para definir presencia/ausencia de Piscina
	public Boolean getTienePiscina() {
		return tienePiscina;
	}
	public void setTienePiscina(Boolean tienePiscina) {
		this.tienePiscina = tienePiscina;
	}

}
