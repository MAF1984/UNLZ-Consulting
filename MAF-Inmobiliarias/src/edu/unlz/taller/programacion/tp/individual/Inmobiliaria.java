package edu.unlz.taller.programacion.tp.individual;
import java.util.*;
/**
 * @author maf
 *
 */

//ATRIBUTOS 
public class Inmobiliaria implements Imprimible {

	private String nombre;
	private Integer cantidadDeInmuebles;
	private Integer MAXIMO_DE_INMUEBLES;
	private Double COMISION;
	protected Set <Inmueble> inmuebles;

	// CONSTRUCTOR
	/**
	 * @param nombre
	 * @param cantidadDeInmuebles
	 * @param inmuebles
	 */

	public Inmobiliaria(String nombre, Integer cantidadDeInmuebles) {
		this.nombre = nombre;
		this.cantidadDeInmuebles = cantidadDeInmuebles;
		this.COMISION = Constantes.COMISION;
		this.inmuebles = new HashSet<Inmueble>();
		this.MAXIMO_DE_INMUEBLES = Constantes.MAXIMO_DE_INMUEBLES;
	}

//METODOS
	
	// Metodo para ingresar Inmuebles
	public void agregarInmueble(Inmueble unInmueble) throws ExisteInmuebleExcep {
		if (this.inmuebles.contains(unInmueble) == false) {
			this.inmuebles.add(unInmueble);
			this.cantidadDeInmuebles++;
		} else {
			new ExisteInmuebleExcep();
		}
	}

	// Metodo para eliminar Inmuebles de collection
	public void eliminarInmueble(Inmueble unInmueble) {
		if (this.inmuebles.contains(unInmueble)) {
			this.inmuebles.remove(unInmueble);
			this.cantidadDeInmuebles--;
				}
		}

	//Beneficio Obtenido
	public Double beneficioObtenido() {
		Double beneficioObtenido = 0.0;
		for (Inmueble unInmueble : this.inmuebles) {
			if (unInmueble.getVendido() || unInmueble.getReservado()) {
				beneficioObtenido += unInmueble.beneficioObtenido(this.getCOMISION());
			}
		}
		return beneficioObtenido;
	}
	
	
	//Benecifio esperado 
	public Double beneficioEsperado() {
		Double beneficioEsperado = 0.0;
		for (Inmueble unInmueble : this.inmuebles) {
			if (unInmueble.getVendido() == false && unInmueble.getReservado() == false) {
				beneficioEsperado += unInmueble.beneficioEsperado(this.getCOMISION());
			}
		}
		return beneficioEsperado;
	}
				


// // Metodo para imprimir los datos 
	public void imprimirDatos() {
		System.out.println("NOMBRE DE LA INMOBILIARIA: " + this.getNombre());
		System.out.println("CANTIDAD DE INMUEBLES: " + this.getCantidadDeInmuebles());
		System.out.println("CANTIDAD MAXIMA DE INMUEBLES: " + this.MAXIMO_DE_INMUEBLES);
		System.out.println("COMISION: " + this.COMISION);
		System.out.println(" ");
		System.out.println("INMUEBLES");
		System.out.println(" ");
		
	}
	//Metodo para listar los inmuebles by precio
	public List<Inmueble> getInmueblesByPrecio()
	/* public void getInmueblesOrdenadosPorPrecio(List<Inmueble> unaLista) */ {
		List<Inmueble> unaLista = new ArrayList<Inmueble>();
		unaLista.addAll(inmuebles);
		Collections.sort(unaLista);
		System.out.println("Listado de Inmuebles por precio ascendente");
		System.out.println("");
		for (Inmueble inmueble : unaLista) {
			if (inmuebles.isEmpty() == false) {
				inmueble.imprimirDatos();
			}
		}
		return unaLista;

	}
	
	
//GETTERS y SETTERS
	//Getter y setter nombre 
	public String getNombre() {
		return nombre;
	}
	public void setNombre(String nombre) {
		this.nombre = nombre;
	}

	//Getter y setter de cantidad de Inmuebles
	public Integer getCantidadDeInmuebles() {
		return cantidadDeInmuebles;
	}
	public void setCantidadDeInmuebles(Integer cantidadDeInmuebles) {
		this.cantidadDeInmuebles = cantidadDeInmuebles;
	}

	//Getter y setter para inmuebles
	public Set<Inmueble> getInmuebles() {
		return inmuebles;
	}

	public void setInmuebles(Set<Inmueble> inmuebles) {
		this.inmuebles = inmuebles;
	}
	
	public Integer getMAXIMO_DE_INMUEBLES() {
		return MAXIMO_DE_INMUEBLES;
	}
	
	//Getter y setter de comisiones del vendedor
	public Double getCOMISION() {
		return COMISION;
	}

	


}