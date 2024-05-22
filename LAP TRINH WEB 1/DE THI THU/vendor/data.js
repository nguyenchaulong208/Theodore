/* SV KHONG chinh sua noi dung trong file nay */
const list = [
  {
    id: 1,
    title: "TYPES OF COFFEE",
    imagePath: "images/img-1.png",
    summary: "Explore diverse coffee styles for a rich caffeine experience.",
    description:
      "Immerse yourself in the world of coffee with its myriad styles that cater to every palate. From the robust and bold flavors of espresso to the smooth and creamy texture of a latte, the spectrum of coffee types is vast. Discover the nuances of brewing methods and origins, as each type offers a unique journey through the global coffee culture. Whether you savor the simplicity of a black coffee or indulge in the complexity of a macchiato, the world of coffee has something to offer for every coffee enthusiast.",
  },
  {
    id: 2,
    title: "BEAN VARIETIES",
    imagePath: "images/img-2.png",
    summary: "Delve into the diverse and flavorful world of coffee beans.",
    description:
      "Uncover the essence of coffee through its diverse bean varieties, each telling a story of its origin and unique characteristics. From the bold and earthy notes of Arabica beans to the robust and intense flavors of Robusta, the choice of beans shapes the entire coffee experience. Journey through the coffee plantations of different regions, understanding how factors like altitude, climate, and processing methods influence the final cup. With beans hailing from Ethiopia to Colombia, the world of coffee is a vibrant tapestry of flavors waiting to be explored.",
  },
  {
    id: 3,
    title: "COFFEE & PASTRY",
    imagePath: "images/img-3.png",
    summary:
      "Pair your favorite brew with delectable pastries for a delightful experience.",
    description:
      "Elevate your coffee ritual by indulging in the delightful harmony of coffee and pastries. Whether it's the classic pairing of a croissant with a cappuccino or the sweetness of a Danish pastry complementing a latte, the combination of coffee and pastries is a sensory delight. Explore the art of balancing the rich, aromatic notes of coffee with the buttery, flaky layers of pastries. From the cozy ambiance of a café to the comfort of your home, this pairing creates a symphony of flavors that transcends the ordinary, making every sip and bite a moment to savor.",
  },
  {
    id: 4,
    title: "COFFEE TO GO",
    imagePath: "images/img-4.png",
    summary: "Embrace convenience with coffee on the move.",
    description:
      "Embodying the spirit of modern lifestyles, Coffee To Go caters to those on the move, ensuring you never miss your daily caffeine fix. Whether you're rushing to work or embarking on a road trip, coffee to go is a convenient companion. From the sleek designs of reusable travel mugs to the quick service at bustling coffee kiosks, this trend encapsulates the fusion of quality and convenience. Dive into the world of portable coffee, where the rich aroma and bold flavors of your favorite brew are just a sip away, no matter where your journey takes you.",
  },
];
// chi so trang bat dau tu 1
function getAll() {
  return list;
}

function getOne(id) {
  return list.filter((item) => item.id == id);
}
