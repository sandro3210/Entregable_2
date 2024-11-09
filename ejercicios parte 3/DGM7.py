import numpy as np

# Generar una muestra de 1000 valores de una distribución normal estándar
media = 0
desviacion_estandar = 1
muestra = np.random.normal(media, desviacion_estandar, 1000)

# Calcular el porcentaje de valores entre -1 y 1
valores_entre_menos1_y_1 = (muestra >= -1) & (muestra <= 1)
porcentaje = np.mean(valores_entre_menos1_y_1) * 100

# Mostrar el resultado
print(f"Porcentaje de valores entre -1 y 1: {porcentaje:.2f}%")
