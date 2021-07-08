using FinalFantasy.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalFantasy
{
    public class Gaming
    {
        //MENU INIZIALE DI GESTIONE DELL'UTENTE
        public static User MenuIniziale()
        {
            return null;
        }

        //MENU PRINCIPALE DI INIZIO PARTITA
        public static bool MenuGiocatore(User giocatore)
        {
            //ALL'INTERNO DI QUESTO MENU VADO A GESTIRE LE OPERAZIONI
            //INIZIALE DI CREAZIONE PARTITA
            //CREAZIONE EROE
            //SCELTA EROE
            //ELIMINARE EROE
            return false;
        }

        public static void Partita(Hero eroeScelto)
        {
            //METODO ALL'INTERNO DEL QUALE VADO A GESTIRE 
            //LA LOGICA RELATIVA AD UNA PARTITA
            
        }

        public static void Battaglia(Hero eroeScelto, Monster mostroSorteggiato)
        {
            //ALL'INTERNO DI QUESTO METODO VENGONO GESTITE LE CASISTICHE DI 
            //VITTORIA-PERDITA DELL'EROE
            //LA BATTAGLIA SI RIPETE FINCHE' L'EROE NON UCCIDE IL MOSTRO O VICEVERSA
        }

        public static bool SceltaTurno(Hero eroe, Monster mostro)
        {
            //METODO CHE CHIEDE ALL'UTENTE QUALE MOSSA ESEGUIRE
            //LOTTA O FUGA
            return false;
        }
    }
}
