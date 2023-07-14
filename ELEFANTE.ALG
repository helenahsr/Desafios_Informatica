Algoritmo "Elefante"

Var

   numElefante, elefantes, setIncomoda: inteiro

Inicio

   escreval("Digite o número de elefantes: ")
   leia(numElefante)
   escreval("")
   para elefantes de 1 ate numElefante passo 1 faca
      se (elefantes mod 2 > 0) entao
         se (elefantes = 1) entao
            escreval(elefantes, " elefante incomoda muita gente!")
         senao
            escreval(elefantes, " elefantes incomoda muita gente!")
         fimse
      senao
         se (elefantes mod 2 = 0) entao
            escreva(elefantes, " elefantes ")
            setIncomoda <- 1
            enquanto (setIncomoda <= elefantes) faca
               escreva("incomodam,")
               setIncomoda <- setIncomoda + 1
            fimenquanto
            escreval(" muito mais!")

         fimse
      fimse
   fimpara

Fimalgoritmo