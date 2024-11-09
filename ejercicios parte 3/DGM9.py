# Import necessary libraries
import numpy as np

# Parameters for the original distribution
mean = 60
std_dev = 10
n = 150

# Generate the sample
sample = np.random.normal(mean, std_dev, n)

# Transform the sample to a standard normal distribution (mean = 0, std dev = 1)
sample_standardized = (sample - np.mean(sample)) / np.std(sample)

# Calculate the mean and standard deviation of the transformed sample to verify
mean_standardized = np.mean(sample_standardized)
std_dev_standardized = np.std(sample_standardized)

print(f"Media de la muestra estandarizada: {mean_standardized}")
print(f"Desviación estándar de la muestra estandarizada: {std_dev_standardized}")
