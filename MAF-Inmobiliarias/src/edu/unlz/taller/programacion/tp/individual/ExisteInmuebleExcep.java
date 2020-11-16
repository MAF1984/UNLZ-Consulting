package edu.unlz.taller.programacion.tp.individual;

public class ExisteInmuebleExcep extends Exception {
	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;

	public ExisteInmuebleExcep() {
		System.out.println("Error. Ese Inmueble ya existe");

	}
}
