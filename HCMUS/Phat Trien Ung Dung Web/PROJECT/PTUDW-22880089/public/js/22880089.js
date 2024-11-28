'use strict';
async function addCart(id, quantity){
    let res = await fetch('/products//cart',{
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
            'Accept': 'application/json'
        },
        body: JSON.stringify({id, quantity})
    });
    let json = await res.json();
    document.getElementById('cart-quantity').innerText = `(${json.quantity})`;
}
