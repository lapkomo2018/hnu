import matplotlib.pyplot as plt
import numpy as np
import utils as ut

x = []
y = []
for i in range(0, 100000, 100):
    arr = np.random.randint(i, size=i).tolist()
    print("Starting for array of size: ", i)
    t, _ = ut.time(ut.remove_duplicates, arr)
    x.append(i)
    y.append(t)
    print("Time taken: ", t)

print(y)

plt.plot(x, y)

plt.xlabel('Size of array')
plt.ylabel('Time taken')

plt.legend()

plt.show()
