def remove_duplicates(arr):
    exists = {}
    res = []
    for i in range(len(arr)):
        if arr[i] not in exists.keys():
            res.append(arr[i])
            exists[arr[i]] = True
    return res

def time(fn, *args):
    import time
    start_time = time.time()
    res = fn(*args)
    return time.time() - start_time, res
