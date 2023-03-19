import os
import time as tm

#Declarando classe
class Carro():

    marca =  input ("Digite a marca do carro: ")
    modelo = input ("Digite o modelo do carro: ")
    ano = input ("Digite o ano do carro: ")
    velocidadeAtual = input ("Digite a velocidade atual do carro: ")
    print('')
    tm.sleep(1)


    #Definindo atributos da classe
    def __init__(self, marca = marca, modelo = modelo, ano = ano, velocidadeAtual = velocidadeAtual):
        self.marca = marca
        self.modelo = modelo
        self.ano = ano
        self.velocidadeAtual = velocidadeAtual

    #Definindo métodos da classe
        #Método de acelerar
    def Acelerar(self, kmh):
        kmh = int(kmh)
        self.velocidadeAtual = int(self.velocidadeAtual)
        self.velocidadeAtual = self.velocidadeAtual + kmh

        #Método de parar
    def Parar(self):
        self.velocidadeAtual = int(self.velocidadeAtual)
        self.velocidadeAtual = 0

        #Métoodo de exibir informações
    def Informacoes(self):
        print("Marca: ", self.marca)
        print("Modelo: ", self.modelo)
        print("Ano: ", self.ano)
        print("Velocidade atual: ", self.velocidadeAtual, " km/h")
        print('')
        print("----------------------------------------------------")
        print('')


#Criando primeiro objeto
if __name__ == "__main__":
    carro1 = Carro()
    carro1.Informacoes()
    carro1.Acelerar(50)
    carro1.Informacoes()
    carro1.Parar()
    carro1.Informacoes()

#Criando vetorização
Carros = []

Carros.append(Carro("Bugatti", "Chiron", 2018, 0))
Carros[0].Informacoes()
Carros[0].Acelerar(20)
Carros[0].Informacoes()

Carros.append(Carro("Ferrari", "F40", 1989, 0))
Carros[1].Informacoes()
Carros[1].Acelerar(40)
Carros[1].Informacoes()

Carros.append(Carro("Ford", "GT", 2018, 0))
Carros[2].Informacoes()
Carros[2].Acelerar(60)
Carros[2].Informacoes()