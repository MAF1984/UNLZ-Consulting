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
		System.out.println("Cantidad de ambientes: " + this.getCantidadDeAmbientes());
		System.out.println("Cuenta con Cochera: " + this.getTieneCochera());
		System.out.println("Cuenta con Piscina: " + this.getTienePiscina());
		System.out.println("");
		super.imprimirDatos();
	}

	
	//Metodo que calcula beneficio obtenido de inmuebles aun no vendidos/Reservados
	public Double beneficioEsperado(Double COMISION) {
		if (this.tienePiscina == true && this.tieneCochera == false) {
			return super.beneficioEsperado(COMISION + Constantes.COMISION_CON_PISCINA);
		} else if (this.tieneCochera == true) {
			return super.beneficioEsperado(COMISION + Constantes.COMISION_CON_COCHERA);
		} else {
			return super.beneficioEsperado(COMISION);
		}
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
	
	//Metodo que calcula beneficio obtenido de inmuebles Vendidos/Reservados
	public Double beneficioObtenido(Double COMISION) {
		if (this.tienePiscina == true && this.tieneCochera == false) {
			return super.beneficioObtenido(COMISION + Constantes.COMISION_CON_PISCINA);
		} else if (this.tieneCochera == true) {
			return super.beneficioObtenido(COMISION + Constantes.COMISION_CON_COCHERA);
		} else {
			return super.beneficioObtenido(COMISION);
		}
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
