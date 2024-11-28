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

async function updateCart(id, quantity){
    if(quantity > 0){
        let res = await fetch('/products/cart',{
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json',
                'Accept': 'application/json'
            },
            body: JSON.stringify({id, quantity})
        });
        if(res.status == 200){
            let json = await res.json();
            document.getElementById('cart-quantity').innerText = `(${json.quantity})`;
            document.getElementById('subtotal').innerText = `(${json.subtotal})`;
            document.getElementById('total${id}').innerText = `($${json.item.total})`;

        }
    }
}