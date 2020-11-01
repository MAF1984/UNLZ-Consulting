/**
 * 
 */
package edu.unlz.taller.programacion.tp.individual;

/**
 * @author maf
 *
 */

//ATRIBUTOS 
public class Inmobiliaria implements Imprimible {

	private String nombre;
	private Integer cantidadDeInmuebles;
	private Integer maximoDeInmuebles = 6;
	private Double comision = 0.05;
	protected Inmueble[] inmuebles;

	// CONSTRUCTOR
	/**
	 * @param nombre
	 * @param cantidadDeInmuebles
	 * @param inmuebles
	 */

	public Inmobiliaria(String nombre, Integer cantidadDeInmuebles) {
		this.nombre = nombre;
		this.cantidadDeInmuebles = cantidadDeInmuebles;
		this.inmuebles = new Inmueble[maximoDeInmuebles];
	}

//METODOS
	// Metodo para recorrer array e ingresar Inmuebles
	public void agregarInmueble(Inmueble unInmueble) {

		for (Inmueble inmueble : inmuebles) {
			if (!unInmueble.equals(inmueble)) {
				for (int i = 0; i < inmuebles.length; i++) {

					if (inmuebles[i] == null && unInmueble != null
							&& unInmueble.getPropietario().datoValido() == true) {
						inmuebles[i] = unInmueble;
						++cantidadDeInmuebles;
						break;

					}
				}
			}
			break;
		}
	}

	// Metodo para recorrer array y eliminar Inmuebles
	public void eliminarInmueble(Inmueble unInmueble) {
		for (int i = 0; i < inmuebles.length; i++) {
			if (inmuebles[i] != null) {

				if (inmuebles[i].equals(unInmueble)) {
					inmuebles[i] = null;
					--cantidadDeInmuebles;
					break;
				}
			}
		}
	}

// benecifio esperado (no incluye los inmuebles vendidos)
	public Double beneficioEsperado() {
		Double totalEsperado = 0.0;
		for (int i = 0; i < inmuebles.length; i++) {
			if (inmuebles[i] != null && inmuebles[i].getVendido() == false) {
				if (inmuebles[i] instanceof Inmueble) {
					totalEsperado += (inmuebles[i].getPrecio() * comision);

				} else if (inmuebles[i] instanceof InmuebleTechado) {
					InmuebleTechado inmuebleTechado = (InmuebleTechado) inmuebles[i];
					if (inmuebleTechado.getTienePiscina() == true && inmuebleTechado.getTieneCochera() == false) {
						totalEsperado += inmuebleTechado.getPrecio() * (comision * 0.05);
					} else if (inmuebleTechado.getTieneCochera() == true) {
						totalEsperado += inmuebleTechado.getPrecio() * (comision * 0.06);
					}
				}

			}

		}
		return totalEsperado;
	}

// // Metodo para recorrer array y calcular el beneficio obtenido de los inmuebles vendidos y reservados
	public double beneficioObtenido() {
		Double totalObtenido = 0.0;
		for (int i = 0; i < inmuebles.length; i++) {
			if (inmuebles[i] != null && (inmuebles[i].getVendido() == true && inmuebles[i].getReservado() == true)) {
				if (inmuebles[i] instanceof Inmueble) {
					totalObtenido += (inmuebles[i].getPrecio() * comision);

				} else if (inmuebles[i] instanceof InmuebleTechado) {
					InmuebleTechado inmuebleTechado = (InmuebleTechado) inmuebles[i];
					if (inmuebleTechado.getTienePiscina() == true && inmuebleTechado.getTieneCochera() == false) {
						totalObtenido += inmuebleTechado.getPrecio() * (comision * 0.05);
					} else if (inmuebleTechado.getTieneCochera() == true) {
						totalObtenido += inmuebleTechado.getPrecio() * (comision * 0.06);
					}
				}

			}

		}
		return totalObtenido;
	}

// // Metodo para imprimir los datos 
	public void imprimirDatos() {
		System.out.println("NOMBRE DE LA INMOBILIARIA: " + this.getNombre());
		System.out.println("CANTIDAD DE INMUEBLES: " + this.getCantidadDeInmuebles());
		System.out.println("CANTIDAD MAXIMA DE INMUEBLES: " + this.getMaximoDeInmuebles());
		System.out.println("COMISION: " + this.getComision());
		System.out.println(" ");
		System.out.println("INMUEBLES");
		System.out.println(" ");
		for (Inmueble inmueble : inmuebles) {
			if (inmueble != null) {
				System.out.println("DATOS DEL INMUEBLE");
				inmueble.imprimirDatos();
			}
		}

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

	//Getter para la cantidad maxima de Inmuebles
	public Integer getMaximoDeInmuebles() {
		return maximoDeInmuebles;
	}

	//Getter y setter de comisiones del vendedor
	public Double getComision() {
		return comision;
	}
	public void setComision(Double comision) {
		this.comision = comision;
	}

	
	public Inmueble[] getInmuebles() {
		return inmuebles;
	}
	public void setInmuebles(Inmueble[] inmuebles) {
		this.inmuebles = inmuebles;
	}

}