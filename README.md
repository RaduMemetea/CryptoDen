# CryptoDen

Aceasta aplicatie este folosita pentru a cripta date folosind diferiti algoritmi sau pentru a calcula hash-ul unui text sau fisier. Ambele functii bazandu-se pe ideea ca input-ul va fi in foramt UTF8.

---

Pentru partea de criptare sunt disponibili trei algoritmi:

1. Caesar (cu shiftare si cheie)
2. Playfaire
3. RSA

---

Pentru partea de calculare a hash-urilor sunt implementate cinci algoritmi:

- MD5 
- SHA1
- SHA256
- SHA384
- SHA512

---

Pe pagina "Crypt" se regasesc doua casete de text; caseta din stanga va contine testul normal iar cea din drapta il va contine pe cel criptat.
Pentru a selecta algoritmul de criptare si ai putea accesa optiunile este necesara selectarea acestuia din casuta de tip dropdown.

In urma actionarii butonului "Encrypt" se va prela textul din caseta stanga, va fi procesat folosind algoritmul selectat si setarile aferente vizibile urmand ca textul criptat sa fie afisat in caseta din dreapta.

In urma actionarii butonului "Decrypt" se va prela textul din caseta dreapta, va fi procesat folosind algoritmul selectat si setarile aferente vizibile urmand ca textul decriptat sa fie afisat in caseta din stanga.

Folosind butonul "Generate Key" se va genera o cheie random de 10 caractere pentru primi doi algoritmi; pentru algoritmul RSA acesta va genera cheia publica si privata criptate folosind Base64. Cheile generate vor contine la inceput marimea cheii urmate de un caracter delimitator si cele doua numere necesare algoritmului serializate folosind XML.

---

Pagina "Hash" este inpartita in doua parti: partea de input si partea de output. 

In zona de input datele pot fi introduse manual sau preluate dintr-un fisier.
Dupa ce metoda de introducere a datelor a fost selectata, se poate actiona butonul "Generate" pentru a se calcula hash-urile pentru inputul primit.

-----------------------------------------------------------------------------------------------------------------------------------------------------

Observatii:

* Inputul pentru aplicatie trebuie sa fie sub forma UTF8
* Pentru algoritmul RSA inputul nu poate fi mai mare decat [ ((marime cheie - 384)/8 )+7 ]
* Pentru cheile pentru algoritmii Caesar si Playfair exista o limita de 25 de caractere
