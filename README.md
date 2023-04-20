WPF Threads:

Introduce un ambiente di sviluppo in Xamarin, risulta minimale, quindi lo rende facile da imparare.
Viene utilizzato per le User Interface (permette di gestire un’applicazione anche al livello grafico), 
WPF ha una sintassi precisa: in XML ogni oggetto è chiuso all’interno di un tag di apertura e di chiusura.

Nell’esercizio WPF Threads: Si vuole visualizzare un conteggio sfruttando le istruzioni multi threads messe a disposizione dal linguaggio C#. 
Si prevedano quindi tre oggetti TextBlock WPF che visualizzano l'avanzamento di tre contatori a velocità diverse.
 Il primo scatta ogni ms e conta fino a 5000 (durata totale 5 secondi).
Il secondo scatta ogni 10ms e conta fino a 500 (durata totale 5 secondi).
Il terzo scatta ogni 100ms e conta fino a 50 (durata totale 5 secondi).
Si preveda un quarto TextBlock che visualizzi il totale dei tre contatori (alla fine visualizza 5.550).
 Si preveda un pulsante "Start" per far partire i conteggi che rimanga disattivato durante il conteggio e si riattivi alla fine.
Per i semafori abbiamo utilizzato la funzione: “CountdownEvent”

Inizializza il semaforo come:
CountdownEvent semaforo = new CountdownEvent (2);

Per bloccare il semaforo usiamo:
semaforo.Wait()

Quando i Threads effettuano un signal:
Dispatcher.Invoke => aspetta (wait)






Creazione del Thread:


Guardare Immagine nella cartella "Creazione Wpf".
