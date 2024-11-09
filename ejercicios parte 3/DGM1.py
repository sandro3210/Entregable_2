import numpy as np
import matplotlib.pyplot as plt

# Generar muestra 
media = 60
desviacion_estandar = 15
muestra = np.random.normal(media, desviacion_estandar, 1000)

# Calcular la media y desviación estándar de la muestra
media_muestra = np.mean(muestra)
desviacion_estandar_muestra = np.std(muestra)

# Graficar histograma de la muestra
plt.hist(muestra, bins=30, color='skyblue', edgecolor='black')
plt.title("Histograma de Muestra de Distribución Normal")
plt.xlabel("Valor")
plt.ylabel("Frecuencia")
plt.show()

media_muestra, desviacion_estandar_muestra
