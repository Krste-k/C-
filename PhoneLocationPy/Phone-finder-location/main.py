import phonenumbers 
import opencage
from myPhone import number

from phonenumbers import geocoder

pepnumber = phonenumbers.parse(number)
location = geocoder.description_for_number(pepnumber,"en")
print(location)

from phonenumbers import carrier
service_pro = phonenumbers.parse(number)
print(carrier.name_for_number(service_pro,"en"))

from opencage.geocoder import OpenCageGeocode

key = 'ea601869f41546669c63461c247c6a99'

geocoder = OpenCageGeocode(key)
query = str(location)
results = geocoder.geocode(query)
# print(results)

lat = results[3]['geometry']['lat']
lng = results[3]['geometry']['lng']
print(lat,lng)


