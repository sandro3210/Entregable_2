# Reimportar librerías y volver a ejecutar el código tras el reinicio del estado
import numpy as np
import matplotlib.pyplot as plt
import scipy.stats as stats

# Parámetros de la distribución
media_muestra = 75
desviacion_estandar_muestra = 8
n = 500

# Generar muestra de distribución normal
muestra = np.random.normal(media_muestra, desviacion_estandar_muestra, n)

# Calcular el intervalo de confianza al 95%
media_muestra_obtenida = np.mean(muestra)
error_estandar = desviacion_estandar_muestra / np.sqrt(n)
intervalo_confianza = stats.norm.interval(0.95, loc=media_muestra_obtenida, scale=error_estandar)

# Graficar la muestra y el intervalo de confianza
plt.figure(figsize=(10, 6))
plt.hist(muestra, bins=30, color='lightblue', edgecolor='black', alpha=0.7, density=True)
plt.axvline(intervalo_confianza[0], color='red', linestyle='--', label=f'Límite inferior: {intervalo_confianza[0]:.2f}')
plt.axvline(intervalo_confianza[1], color='green', linestyle='--', label=f'Límite superior: {intervalo_confianza[1]:.2f}')
plt.axvline(media_muestra_obtenida, color='blue', linestyle='-', label=f'Media de la muestra: {media_muestra_obtenida:.2f}')
plt.title("Histograma de la Muestra con Intervalo de Confianza al 95% para la Media")
plt.xlabel("Valor")
plt.ylabel("Densidad")
plt.legend()
plt.show()

intervalo_confianza, media_muestra_obtenida
