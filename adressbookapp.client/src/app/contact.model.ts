export interface Contact {
  name: {
    title: string;
    first: string;
    last: string;
  };
  email: string;
  city: string;
  phone: string
}


//export interface ContactResponseSchema {
//  info: {
//    page: number;
//    results: number;
//    seed: string;
//    version: string;
//  };
//  results: Contact[];
//}

//export interface Contact {
//  cell: string;
//  dob: {
//    age: number;
//    date: string;
//  };
//  email: string;
//  gender: string;
//  id: {
//    name: string;
//    value: string;
//  };
//  location: {
//    city: string;
//    coordinates: {
//      latitude: string;
//      longitude: string;
//    };
//    country: string;
//    postcode: number;
//    state: string;
//    street: {
//      number: number;
//      name: string;
//    };
//    timezone: {
//      description: string;
//      offset: string;
//    };
//  };
//  login: {
//    md5: string;
//    password: string;
//    salt: string;
//    sha1: string;
//    sha256: string;
//    username: string;
//    uuid: string;
//  };
//  name: {
//    first: string;
//    last: string;
//    title: string;
//  };
//  nat: string;
//  phone: string;
//  picture: {
//    large: string;
//    medium: string;
//    thumbnail: string;
//  };
//  registered: {
//    age: number;
//    date: string;
//  };
//}

