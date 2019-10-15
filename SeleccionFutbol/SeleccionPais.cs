using System;
using System.Collections.Generic;

namespace SeleccionFutbol
{
    internal class SeleccionPais
    {
        public string NombrePais { get; set; }

        public List<SeleccionFutbol> Participantes { get; set; }

        public int NumeroParticipantes { get; set; }

        public SeleccionPais(string nombrePais, List<SeleccionFutbol> participantes, int numeroParticipantes)
        {
            NombrePais = nombrePais;
            Participantes = participantes;
            NumeroParticipantes = numeroParticipantes; // En la corrección del ejercicio, no se usa.
        }

        public void MostrarDatosSeleccion()

        {
            Console.WriteLine($" País: {NombrePais}");
            Console.WriteLine($" Expedición: {Participantes.Count}");

            foreach (SeleccionFutbol miembros in Participantes)
            {
                miembros.MostrarDatos();
            }
        }

        public bool AltaSeleccion()
        {
            if (Participantes.Count < 30)
            {
                int contMasajistas = 0;
                int contEntrenador = 0;
                foreach (SeleccionFutbol integrante in Participantes)
                {
                    //if(integrante.GetType().Name == "Masajista")
                    if (integrante is Masajista)
                    {
                        contMasajistas++;
                    }
                    else if (integrante is Entrenador)
                    {
                        contEntrenador++;
                    }
                }
                Console.WriteLine("Introduce el tipo de integrante a dar de alta:Entrenador(e)/Masajista(m)/Futbolista(f))");
                string respuesta = Console.ReadLine().ToLower();
                switch (respuesta)
                {
                    case "e":
                        if (contEntrenador < 2)
                        {
                            Console.WriteLine("Introduce tu Id de la federación:");
                            string idFederacion = Console.ReadLine();
                            SeleccionFutbol seleccion = NewSeleccionFutbol();
                            Entrenador entrenador = new Entrenador(idFederacion, seleccion.Id, seleccion.Nombre, seleccion.Apellidos, seleccion.Edad);
                            Participantes.Add(entrenador);
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("No hay sitio para más entrenadores");
                            return false;
                        }

                    case "m":
                        if (contMasajistas < 4)
                        {
                            Console.WriteLine("Introduce tu titulación:");
                            string titulación = Console.ReadLine();
                            Console.WriteLine("Introduce tus años de experiencia:");
                            int aniosExp = Convert.ToInt32(Console.ReadLine());
                            SeleccionFutbol seleccion = NewSeleccionFutbol();
                            Masajista masajista = new Masajista(titulación, aniosExp, seleccion.Id, seleccion.Nombre, seleccion.Apellidos, seleccion.Edad);
                            Participantes.Add(masajista);
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("No hay sitio para más masajistas");
                            return false;
                        }

                    case "f":
                        Console.WriteLine("Introduce tu Dorsal:");
                        int dorsal = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Introduce tu demarcación:");
                        string demarcacion = Console.ReadLine();
                        SeleccionFutbol seleccionFutbol = NewSeleccionFutbol();
                        Futbolista futbolista = new Futbolista(dorsal, demarcacion, seleccionFutbol.Id, seleccionFutbol.Nombre, seleccionFutbol.Apellidos, seleccionFutbol.Edad);
                        Participantes.Add(futbolista);
                        return true;

                    default:
                        Console.WriteLine("Error. Letra incorrecta.");

                        return false;
                }
            }
            else
            {
                Console.WriteLine("No hay sitio para más integrantes");
                return false;
            }
        }

        public SeleccionFutbol NewSeleccionFutbol()
        {
            Console.WriteLine("Introduce el nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("Introduce el apellido");
            string apellido = Console.ReadLine();
            Console.WriteLine("Introduce el id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce la edad");
            int edad = Convert.ToInt32(Console.ReadLine());
            return new SeleccionFutbol(id, nombre, apellido, edad);
        }

        public bool DarDeBaja()
        {
            Console.WriteLine("Introduce el id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            bool borrado = false;
            for (int i = 0; i < Participantes.Count; i++)
            {
                if (id == Participantes[i].Id)
                {
                    Participantes.Remove(Participantes[i]);
                    i--;
                    borrado = true;
                }
            }
            return borrado;
        }
    }
}