function sortArray(arr, sortType){
    let array = arr;
    if(sortType === 'asc'){
        array = array.sort((a, b) => a - b);
    } else if(sortType === 'desc'){
        array = array.sort((a, b) => b - a);
    };
    return array;
}

console.log(sortArray([14, 7, 17, 6, 8], 'desc'));