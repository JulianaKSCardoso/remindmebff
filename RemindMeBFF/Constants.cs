﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RemindeMeBFF
{
    public class Constants
    {
        public const string medicaments = @"[
    {
      'id': 1,
      'name': 'Dipirona Monoidratada',
      'about': '550MG',
      'tips': 'Este medicamento é indicado como analgésico (para dor) e antitérmico (para febre)',
      'photo': 'https://images.vexels.com/media/users/3/144240/isolated/lists/ce9102820c3ec30860f5e0519c5c2c64-pills-icon-remedy.png',
      'medicament_type': ['analgesic'],
      'frequency': {
        'times': 4,
        'repeat_every': 'day'
      }
    },
    {
      'id': 2,
      'name': 'Amoxilina',
      'about': '250MG',
      'tips': 'Antibiótico indicado para tratamento de infecções bacterianas ocasionadas por germes sensíveis à ação da amoxicilina.',
      'photo': 'https://images.vexels.com/media/users/3/144240/isolated/lists/ce9102820c3ec30860f5e0519c5c2c64-pills-icon-remedy.png',
      'medicament_type': ['antibiotic'],
      'frequency': {
        'times': 3,
        'repeat_every': 'day'
      }
    },
    {
      'id': 3,
      'name': 'Suplemento Vitamínico Cálcio com Vitamina D',
      'about': '500mg + 400 UI',
      'tips': 'Pessoas com os seguintes problemas de saúde devem utilizar o produto sob supervisão médica: hipercalciúria leve, insuficiência renal crônica, ou quando existe propensão à formação de cálculos renais',
      'photo': 'https://images.vexels.com/media/users/3/144240/isolated/lists/ce9102820c3ec30860f5e0519c5c2c64-pills-icon-remedy.png',
      'medicament_type': ['supplement'],
      'frequency': {
        'times': 1,
        'repeat_every': 'week'
      }
    },
    {
      'id': 4,
      'name': 'Nimesulida',
      'about': '100MG',
      'tips': 'Este medicamento é destinado ao tratamento de uma variedade de condições que requeiram atividade anti-inflamatória, analgésica e antipirética.',
      'photo': 'https://images.vexels.com/media/users/3/144240/isolated/lists/ce9102820c3ec30860f5e0519c5c2c64-pills-icon-remedy.png',
      'medicament_type': ['antiinflammatory'],
      'frequency': {
        'times': 3,
        'repeat_every': 'day'
      }
    },
    {
      'id': 5,
      'name': 'Gerovital',
      'about': 'O aroma reduz os níveis de ansiedade e seu cheiro ajudar na qualidade do sono e a produtividade durante o dia.',
      'tips': ' indicado no tratamento de diminuição do rendimento físico e mental, estados de fadiga e esgotamento, distúrbios de memória, diminuição da capacidade de concentração e envelhecimento precoce.',
      'photo': 'https://images.vexels.com/media/users/3/144240/isolated/lists/ce9102820c3ec30860f5e0519c5c2c64-pills-icon-remedy.png',
      'medicament_type': ['supplement'],
      'frequency': {
        'times': 1,
        'repeat_every': 'day'
      }
    },
    {
      'id': 6,
      'name': 'Ômega 3',
      'about': '1000mg',
      'tips': 'Auxilia na manutenção de níveis saudáveis de triglicerídeos, melhora a capacidade de concentração, a memória, o sistema imunológico e a pele, além de combater o stress.',
      'photo': 'https://images.vexels.com/media/users/3/144240/isolated/lists/ce9102820c3ec30860f5e0519c5c2c64-pills-icon-remedy.png',
      'medicament_type': ['supplement'],
      'frequency': {
        'times': 2,
        'repeat_every': 'day'
      }
    },
    {
      'id': 7,
      'name': 'Dorflex',
      'about': 'Dipirona monoidratada 300mg, citrato de orfenadrina 35mg, cafeína anidra 50mg.',
      'tips': 'A combinação de dipirona, orfenadrina e cafeína é utilizada para aliviar dores e tensões musculares.',
      'photo': 'https://images.vexels.com/media/users/3/144240/isolated/lists/ce9102820c3ec30860f5e0519c5c2c64-pills-icon-remedy.png',
      'medicament_type': ['analgesic'],
      'frequency': {
        'times': 3,
        'repeat_every': 'day'
      }
    },
    {
      'id': 8,
      'name': 'Novalgina',
      'about': 'Dipirona Monoidratada',
      'tips': 'Indicado em adultos para a redução da febre e para o alívio temporário de dores leves a moderadas.',
      'photo': 'https://images.vexels.com/media/users/3/144240/isolated/lists/ce9102820c3ec30860f5e0519c5c2c64-pills-icon-remedy.png',
      'medicament_type': ['analgesic'],
      'frequency': {
        'times': 4,
        'repeat_every': 'day'
      }
    },
    {
      'id': 9,
      'name': 'Vitaxon C',
      'about': 'Vitamina C 1g, Vitamina D 400UI, Zinco 10mg',
      'tips': 'Auxilia no sistema imunológico, melhora a resposta das células de defesa.',
      'photo': 'https://images.vexels.com/media/users/3/144240/isolated/lists/ce9102820c3ec30860f5e0519c5c2c64-pills-icon-remedy.png',
      'medicament_type': ['suplemment'],
      'frequency': {
        'times': 2,
        'repeat_every': 'week'
      }
    },
    {
      'id': 10,
      'name': 'Vitamina D3 Althaia',
      'about': '2000UI',
      'tips': 'Previne e auxilia o tratamento e prevenção da desmineralização óssea, raquitismo, e osteomalácia.',
      'photo': 'https://images.vexels.com/media/users/3/144240/isolated/lists/ce9102820c3ec30860f5e0519c5c2c64-pills-icon-remedy.png',
      'medicament_type': ['suplemment'],
      'frequency': {
        'times': 1,
        'repeat_every': 'day'
      }
    }
  ]";

        public const string medicaments_type = @" [
    {'key': 'analgesic', 'title': 'Analgésico'},
    {'key': 'antibiotic', 'title': 'Antibiótico'},
    {'key': 'supplement', 'title': 'Suplemento'},
    {'key': 'antiinflammatory', 'title': 'Anti-Inflamatório'}
  ]";

        public const string medicaments_frequencies = @" [
    {'key': 'day', 'title': 'Todos os dias'},
    {'key': 'week', 'title': 'Ingestão semanal'}
  ]";


    }
}
