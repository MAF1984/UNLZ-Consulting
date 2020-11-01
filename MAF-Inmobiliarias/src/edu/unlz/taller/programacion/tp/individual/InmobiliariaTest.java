package edu.unlz.taller.programacion.tp.individual;

public class InmobiliariaTest {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// Declaramos una inmobiliaria de prueba
		Inmobiliaria inmobi = new Inmobiliaria("Inmobiliaria-Test", 0);
		
		// Generamos algunos clientes para asignar las propiedades
		Cliente cliente1 = new Cliente("Mariano", "42332130", "Marianofleming@gmail.com");
		Cliente cliente2 = new Cliente("Alejandro", "1149274791", "maf1984@hotmail.com");
		Cliente cliente3 = new Cliente("Fleming", "55555555", "mfleming@asociart.com.ar");
		
		// Declaro inmuebles "normales" de la clase 'Inmueble' con variables posibles para los atributos booleanos de 'reservado' y 'vendido'
		Inmueble inmuebleNormal = new Inmueble("Florida 402", 25, 10000.0, false, false, cliente1);
		Inmueble inmuebleNormalReser = new Inmueble("Callao 1542", 40, 25000.0, true, false, cliente2);
		Inmueble inmuebleNormalReserVendido = new Inmueble("Callao 1542", 48, 30200.0, true, true, cliente2);
		Inmueble inmuebleNormalVendido = new Inmueble("San Martin 325", 36, 18000.0, false, true, cliente2);
		
		// Declaro inmuebles "techados" de la clase 'InmuebleTechado' con variables posibles para los atributos booleanos de 'reservado','vendido','tieneCochera','tienePiscina'
		Inmueble inmuebleTechado = new InmuebleTechado("Uruguay 1724", 120, 220000.0, true, true, cliente3, 6, true, true);
		Inmueble inmuebleTechReservado = new InmuebleTechado("Yrigoyen 1200", 89, 80000.0, true, true, cliente1, 3, true, false);
		Inmueble inmuebleTechReserVendido = new InmuebleTechado("Yrigoyen 1200", 70, 68000.0, true, true, cliente3, 3, false, false);
		Inmueble inmuebleTechadoPiscina = new InmuebleTechado("Vernier 775", 77, 77000.0, false, false, cliente2, 4, true, false);
		Inmueble inmuebleTechadoCochera = new InmuebleTechado("Mendizabal 224", 77, 77000.0, false, false, cliente3, 5, true, false);
		
		
		// Ingreso 6 inmuebles 
		inmobi.agregarInmueble(inmuebleNormal);
		inmobi.agregarInmueble(inmuebleNormalReser);
		inmobi.agregarInmueble(inmuebleNormalReserVendido);
		inmobi.agregarInmueble(inmuebleNormalVendido);
		inmobi.agregarInmueble(inmuebleTechado);
		inmobi.agregarInmueble(inmuebleTechReservado);
		
		// Elimino 2 inmuebles
		inmobi.eliminarInmueble(inmuebleNormal);
		inmobi.eliminarInmueble(inmuebleNormalReser);
		
		// Ingreso otros 2 inmuebles que no hayan sido ingresados con anterioridad
		inmobi.agregarInmueble(inmuebleTechadoCochera);
		inmobi.agregarInmueble(inmuebleTechadoPiscina);
		
		// Intento agregar un inmueble repetido
		inmobi.agregarInmueble(inmuebleTechadoPiscina);
		
		// Intento eliminar un inmueble inexistente en el array
		inmobi.eliminarInmueble(inmuebleTechReserVendido);
		
		//Imprimo todos los datos
		inmobi.imprimirDatos();
		System.out.println("");
		
		//imprimo los datos de beneficios esperados y obtenidos
		System.out.println("BENEFICIO ESPERADO: " + inmobi.beneficioEsperado());
		System.out.println("BENEFICIO OBTENIDO: " + inmobi.beneficioObtenido());
	}
}