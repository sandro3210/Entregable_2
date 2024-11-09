# Import necessary libraries
import numpy as np
import matplotlib.pyplot as plt

# Parameters for the normal distribution
mean = 100
std_dev = 20
n = 100

# Generate the sample
sample = np.random.normal(mean, std_dev, n)

# Calculate the 90th percentile
percentile_90 = np.percentile(sample, 90)

# Print the result
print(f"Percentil 90: {percentile_90}")

# Create a histogram of the sample
plt.hist(sample, bins=20, color='skyblue', edgecolor='black', alpha=0.7)
plt.axvline(percentile_90, color='red', linestyle='dashed', linewidth=2)
plt.text(percentile_90 + 5, 10, f'Percentil 90: {percentile_90:.2f}', color='red', fontsize=12)
plt.title('Distribución de la Muestra con Percentil 90')
plt.xlabel('Valores')
plt.ylabel('Frecuencia')
plt.show()

